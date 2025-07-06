using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFMpegCore; // ¡La librería que hace la magia!
using FFMpegCore.Enums;

namespace TikTokVideoMakerFinal
{
    public partial class Form1 : Form
    {
        private string gifPath = "";
        private string audioPath = "";

        public Form1()
        {
            InitializeComponent();
            SetupTheme(); // Aplicar el tema oscuro
        }

        // =======================================================
        // CÓDIGO DEL DISEÑO
        // =======================================================
        private void SetupTheme()
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.ForeColor = Color.White;
            this.Text = "Creador de Video para TikTok (¡Ahora sí!)";

            // Asumiendo que tus controles se llaman btnSelectGif, btnSelectAudio, etc.
            // Si tienen otros nombres, ajústalos aquí o en el diseñador.
            // Ejemplo para un botón:
            btnGenerate.BackColor = Color.SeaGreen;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        // =======================================================
        // CÓDIGO FUNCIONAL
        // =======================================================

        private void btnSelectGif_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = "Archivos GIF (*.gif)|*.gif" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    gifPath = openFileDialog.FileName;
                    //Suponiendo que tienes un textbox llamado txtGifPath
                    txtGifPath.Text = gifPath; 
                }
            }
        }

        private void btnSelectAudio_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = "Archivos de Audio (*.mp3;*.wav)|*.mp3;*.wav" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    audioPath = openFileDialog.FileName;
                    //Suponiendo que tienes un textbox llamado txtAudioPath
                    txtAudioPath.Text = audioPath;
                }
            }
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gifPath) || string.IsNullOrEmpty(audioPath))
            {
                MessageBox.Show("Por favor, selecciona un archivo GIF y un archivo de audio.", "Faltan archivos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetUIEnabled(false);
            // Suponiendo que tienes una label lblStatus y una progressbar progressBar
            lblStatus.Text = "Procesando video...";
            progressBar.Value = 0;

            try
            {
                string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"tiktok_video_{DateTime.Now:yyyyMMdd_HHmmss}.mp4");

                // Cambiamos el estilo de la barra de progreso a Marquee
                progressBar.Style = ProgressBarStyle.Marquee;
                lblStatus.Text = "Procesando video...";

                await FFMpegArguments
                    .FromFileInput(gifPath)
                    .AddFileInput(audioPath)
                    .OutputToFile(outputPath, true, options => options
                        .WithVideoCodec(VideoCodec.LibX264)
                        .WithAudioCodec(AudioCodec.Aac)
                        .WithAudioBitrate(192)
                        .WithCustomArgument("-pix_fmt yuv420p")
                        .WithCustomArgument("-vf \"scale=1080:1920:force_original_aspect_ratio=decrease,pad=1080:1920:(ow-iw)/2:(oh-ih)/2,setsar=1\"")
                        .WithCustomArgument("-shortest")
                        .WithFastStart()
                    )
                    // HEMOS ELIMINADO LA LÍNEA .NotifyOnProgress()
                    .ProcessAsynchronously();

                MessageBox.Show($"¡Video creado con éxito!\n\nGuardado en: {outputPath}", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error:\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetUIEnabled(true);
                lblStatus.Text = "Listo.";
                progressBar.Style = ProgressBarStyle.Blocks; // La devolvemos a su estado normal
                progressBar.Value = 0;
            }
        }

        private void SetUIEnabled(bool isEnabled)
        {
            btnSelectGif.Enabled = isEnabled;
            btnSelectAudio.Enabled = isEnabled;
            btnGenerate.Enabled = isEnabled;
        }
    }
}