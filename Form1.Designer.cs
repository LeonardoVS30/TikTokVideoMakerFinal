namespace TikTokVideoMakerFinal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvSequence = new System.Windows.Forms.ListView();
            this.btnAddGif = new System.Windows.Forms.Button();
            this.btnRemoveGif = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numRepetitions = new System.Windows.Forms.NumericUpDown();
            this.lblAudioPath = new System.Windows.Forms.Label();
            this.btnSelectAudio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numRepetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lvSequence
            // 
            this.lvSequence.FullRowSelect = true;
            this.lvSequence.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSequence.HideSelection = false;
            this.lvSequence.Location = new System.Drawing.Point(13, 22);
            this.lvSequence.Name = "lvSequence";
            this.lvSequence.Size = new System.Drawing.Size(775, 214);
            this.lvSequence.TabIndex = 0;
            this.lvSequence.UseCompatibleStateImageBehavior = false;
            this.lvSequence.View = System.Windows.Forms.View.Details;
            this.lvSequence.Click += new System.EventHandler(this.lvSequence_SelectedIndexChanged);
            // 
            // btnAddGif
            // 
            this.btnAddGif.BackColor = System.Drawing.Color.DimGray;
            this.btnAddGif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGif.ForeColor = System.Drawing.Color.White;
            this.btnAddGif.Location = new System.Drawing.Point(12, 266);
            this.btnAddGif.Name = "btnAddGif";
            this.btnAddGif.Size = new System.Drawing.Size(75, 33);
            this.btnAddGif.TabIndex = 1;
            this.btnAddGif.Text = "Añadir GIF";
            this.btnAddGif.UseVisualStyleBackColor = false;
            this.btnAddGif.Click += new System.EventHandler(this.btnAddGif_Click);
            // 
            // btnRemoveGif
            // 
            this.btnRemoveGif.BackColor = System.Drawing.Color.DimGray;
            this.btnRemoveGif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGif.ForeColor = System.Drawing.Color.White;
            this.btnRemoveGif.Location = new System.Drawing.Point(108, 266);
            this.btnRemoveGif.Name = "btnRemoveGif";
            this.btnRemoveGif.Size = new System.Drawing.Size(75, 33);
            this.btnRemoveGif.TabIndex = 2;
            this.btnRemoveGif.Text = "Quitar";
            this.btnRemoveGif.UseVisualStyleBackColor = false;
            this.btnRemoveGif.Click += new System.EventHandler(this.btnRemoveGif_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.Color.DimGray;
            this.btnMoveUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveUp.ForeColor = System.Drawing.Color.White;
            this.btnMoveUp.Location = new System.Drawing.Point(213, 266);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 33);
            this.btnMoveUp.TabIndex = 3;
            this.btnMoveUp.Text = "Subir";
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.Color.DimGray;
            this.btnMoveDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDown.ForeColor = System.Drawing.Color.White;
            this.btnMoveDown.Location = new System.Drawing.Point(319, 266);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 33);
            this.btnMoveDown.TabIndex = 4;
            this.btnMoveDown.Text = "Bajar";
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Repeticiones del GIF:";
            // 
            // numRepetitions
            // 
            this.numRepetitions.Location = new System.Drawing.Point(213, 333);
            this.numRepetitions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRepetitions.Name = "numRepetitions";
            this.numRepetitions.Size = new System.Drawing.Size(120, 20);
            this.numRepetitions.TabIndex = 6;
            this.numRepetitions.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRepetitions.Click += new System.EventHandler(this.numRepetitions_ValueChanged);
            // 
            // lblAudioPath
            // 
            this.lblAudioPath.AutoSize = true;
            this.lblAudioPath.Location = new System.Drawing.Point(16, 401);
            this.lblAudioPath.Name = "lblAudioPath";
            this.lblAudioPath.Size = new System.Drawing.Size(115, 13);
            this.lblAudioPath.TabIndex = 7;
            this.lblAudioPath.Text = "Audio no seleccionado";
            // 
            // btnSelectAudio
            // 
            this.btnSelectAudio.Location = new System.Drawing.Point(213, 391);
            this.btnSelectAudio.Name = "btnSelectAudio";
            this.btnSelectAudio.Size = new System.Drawing.Size(120, 23);
            this.btnSelectAudio.TabIndex = 8;
            this.btnSelectAudio.Text = "Seleccionar Audio...";
            this.btnSelectAudio.UseVisualStyleBackColor = true;
            this.btnSelectAudio.Click += new System.EventHandler(this.btnSelectAudio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Duración Final (segundos):";
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(213, 453);
            this.numDuration.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numDuration.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(120, 20);
            this.numDuration.TabIndex = 10;
            this.numDuration.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Gray;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(258, 574);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(268, 82);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "GENERAR VIDEO";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(372, 668);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Estado";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 727);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(775, 23);
            this.progressBar.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 796);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectAudio);
            this.Controls.Add(this.lblAudioPath);
            this.Controls.Add(this.numRepetitions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnRemoveGif);
            this.Controls.Add(this.btnAddGif);
            this.Controls.Add(this.lvSequence);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numRepetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSequence;
        private System.Windows.Forms.Button btnAddGif;
        private System.Windows.Forms.Button btnRemoveGif;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRepetitions;
        private System.Windows.Forms.Label lblAudioPath;
        private System.Windows.Forms.Button btnSelectAudio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}