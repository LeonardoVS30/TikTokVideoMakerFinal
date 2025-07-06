using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FFMpegCore; // Para FFMpegArguments
using FFMpegCore.Enums; // Para VideoCodec, etc.
using FFMpegCore.Pipes; // ¡IMPORTANTE! Para IVidepPipeSource
using System.Threading.Tasks; // Para Task

namespace TikTokVideoMakerFinal
{
    public class GifSequenceItem
    {
        public string FilePath { get; set; }
        public int Repetitions { get; set; } = 2;
        public override string ToString() => $"{Path.GetFileName(FilePath)} (Repeticiones: {Repetitions})";
    }

    public partial class Form1 : Form
    {
        private List<GifSequenceItem> gifSequence = new List<GifSequenceItem>();
        private string audioPath = "";

        public Form1()
        {
            InitializeComponent();
            SetupTheme();
            lvSequence.Columns.Add("Secuencia", -2);
        }

        private void SetupTheme()
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.ForeColor = Color.White;
            this.Text = "Creador de Video para TikTok v2.0 - ¡Funcional!";
        }

        // =======================================================
        // LÓGICA DE LA INTERFAZ (Eventos de los botones, etc.)
        // =======================================================

        // --- PEGA AQUÍ LOS MÉTODOS QUE YA TIENES Y FUNCIONAN ---
        // btnAddGif_Click, btnRemoveGif_Click, btnMoveUp_Click, btnMoveDown_Click,
        // lvSequence_SelectedIndexChanged, numRepetitions_ValueChanged, btnSelectAudio_Click
        // ... por ejemplo:
        private void btnAddGif_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = "Archivos GIF (*.gif)|*.gif", Multiselect = true })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        gifSequence.Add(new GifSequenceItem { FilePath = file });
                    }
                    RefreshListView();
                }
            }
        }

        // (Asegúrate de tener todos los demás métodos de la interfaz aquí)
        // ...

        private void RefreshListView()
        {
            lvSequence.Items.Clear();
            foreach (var item in gifSequence)
            {
                lvSequence.Items.Add(new ListViewItem(item.ToString()));
            }

            bool itemSelected = lvSequence.SelectedItems.Count > 0;
            btnRemoveGif.Enabled = itemSelected;
            btnMoveUp.Enabled = itemSelected && lvSequence.SelectedIndices[0] > 0;
            btnMoveDown.Enabled = itemSelected && lvSequence.SelectedIndices[0] < gifSequence.Count - 1;
            numRepetitions.Enabled = itemSelected;
        }

        private void btnRemoveGif_Click(object sender, EventArgs e)
        {
            if (lvSequence.SelectedItems.Count > 0)
            {
                int selectedIndex = lvSequence.SelectedIndices[0];
                gifSequence.RemoveAt(selectedIndex);
                RefreshListView();
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (lvSequence.SelectedItems.Count > 0)
            {
                int index = lvSequence.SelectedIndices[0];
                if (index > 0)
                {
                    var item = gifSequence[index];
                    gifSequence.RemoveAt(index);
                    gifSequence.Insert(index - 1, item);
                    RefreshListView();
                    if (lvSequence.Items.Count > index - 1) lvSequence.Items[index - 1].Selected = true;
                }
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (lvSequence.SelectedItems.Count > 0)
            {
                int index = lvSequence.SelectedIndices[0];
                if (index < gifSequence.Count - 1)
                {
                    var item = gifSequence[index];
                    gifSequence.RemoveAt(index);
                    gifSequence.Insert(index + 1, item);
                    RefreshListView();
                    if (lvSequence.Items.Count > index + 1) lvSequence.Items[index + 1].Selected = true;
                }
            }
        }

        private void lvSequence_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSequence.SelectedItems.Count > 0)
            {
                int selectedIndex = lvSequence.SelectedIndices[0];
                this.numRepetitions.ValueChanged -= new System.EventHandler(this.numRepetitions_ValueChanged);
                numRepetitions.Value = gifSequence[selectedIndex].Repetitions;
                this.numRepetitions.ValueChanged += new System.EventHandler(this.numRepetitions_ValueChanged);
            }
            RefreshListView();
        }

        private void numRepetitions_ValueChanged(object sender, EventArgs e)
        {
            if (lvSequence.SelectedItems.Count > 0)
            {
                int selectedIndex = lvSequence.SelectedIndices[0];
                gifSequence[selectedIndex].Repetitions = (int)numRepetitions.Value;
                lvSequence.SelectedItems[0].Text = gifSequence[selectedIndex].ToString();
            }
        }

        private void btnSelectAudio_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = "Archivos de Audio (*.mp3;*.wav)|*.mp3;*.wav" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    audioPath = openFileDialog.FileName;
                    lblAudioPath.Text = $"Audio: {Path.GetFileName(audioPath)}";
                }
            }
        }

        // =======================================================
        //          MÉTODO GENERATE_CLICK CORREGIDO
        // =======================================================
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            if (gifSequence.Count == 0)
            {
                MessageBox.Show("Por favor, añade al menos un GIF a la secuencia.", "Secuencia Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(audioPath))
            {
                MessageBox.Show("Por favor, selecciona un archivo de audio.", "Falta Audio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetUIEnabled(false);
            lblStatus.Text = "Procesando video...";
            progressBar.Style = ProgressBarStyle.Marquee;

            try
            {
                string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"tiktok_video_{DateTime.Now:yyyyMMdd_HHmmss}.mp4");

                // --- 3. CONSTRUCCIÓN DEL FILTRO COMPLEJO (VERSIÓN FINAL) ---
                var filterComplex = new System.Text.StringBuilder();

                // A. Repetir CADA GIF y NORMALIZAR su tamaño al mismo tiempo
                for (int i = 0; i < gifSequence.Count; i++)
                {
                    filterComplex.Append($"[{i}:v]scale=1080:1920:force_original_aspect_ratio=decrease,pad=1080:1920:(ow-iw)/2:(oh-ih)/2,setsar=1,format=yuv420p,setpts=N/FRAME_RATE/TB,loop=loop={gifSequence[i].Repetitions - 1}:size=32767:start=0[v{i}];");
                }

                // B. Concatenar los GIFs ya normalizados y repetidos
                for (int i = 0; i < gifSequence.Count; i++)
                {
                    filterComplex.Append($"[v{i}]");
                }
                filterComplex.Append($"concat=n={gifSequence.Count}:v=1:a=0[vfinal]");

                // C. Ejecutar el proceso
                var arguments = FFMpegArguments.FromFileInput(gifSequence[0].FilePath);
                for (int j = 1; j < gifSequence.Count; j++)
                {
                    arguments.AddFileInput(gifSequence[j].FilePath);
                }

                var success = await arguments
                    .AddFileInput(audioPath)
                    .OutputToFile(outputPath, true, options => options
                        .WithVideoCodec(VideoCodec.LibX264)
                        .WithAudioCodec(AudioCodec.Aac)
                        .WithAudioBitrate(192)
                        .WithCustomArgument($"-filter_complex \"{filterComplex.ToString()}\"")
                        .WithCustomArgument($"-map \"[vfinal]\"")
                        .WithCustomArgument($"-map {gifSequence.Count}:a")
                        .WithDuration(TimeSpan.FromSeconds((double)numDuration.Value))
                        .WithFastStart()
                    )
                    .ProcessAsynchronously();

                if (success)
                {
                    MessageBox.Show($"¡Video creado con éxito!\n\nGuardado en: {outputPath}", "¡VICTORIA FINAL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("FFmpeg encontró un error durante el procesamiento. Revisa la salida para más detalles.", "Error de FFmpeg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado:\n\n{ex.ToString()}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetUIEnabled(true);
                lblStatus.Text = "Listo.";
                progressBar.Style = ProgressBarStyle.Blocks;
                progressBar.Value = 0;
            }
        }

        // =======================================================
        //          MÉTODO AUXILIAR (SOLO UNO)
        // =======================================================
        private void SetUIEnabled(bool isEnabled)
        {
            btnAddGif.Enabled = isEnabled;
            btnRemoveGif.Enabled = isEnabled;
            btnMoveUp.Enabled = isEnabled;
            btnMoveDown.Enabled = isEnabled;
            btnSelectAudio.Enabled = isEnabled;
            btnGenerate.Enabled = isEnabled;
            numRepetitions.Enabled = isEnabled;
            numDuration.Enabled = isEnabled;
            lvSequence.Enabled = isEnabled;
        }
    }
}