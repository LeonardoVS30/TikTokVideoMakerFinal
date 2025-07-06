namespace TikTokVideoMakerFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectGif = new System.Windows.Forms.Button();
            this.txtGifPath = new System.Windows.Forms.TextBox();
            this.btnSelectAudio = new System.Windows.Forms.Button();
            this.txtAudioPath = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnSelectGif
            // 
            this.btnSelectGif.BackColor = System.Drawing.Color.Black;
            this.btnSelectGif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectGif.ForeColor = System.Drawing.Color.White;
            this.btnSelectGif.Location = new System.Drawing.Point(109, 133);
            this.btnSelectGif.Name = "btnSelectGif";
            this.btnSelectGif.Size = new System.Drawing.Size(180, 40);
            this.btnSelectGif.TabIndex = 0;
            this.btnSelectGif.Text = "Seleccionar GIF...";
            this.btnSelectGif.UseVisualStyleBackColor = false;
            this.btnSelectGif.Click += new System.EventHandler(this.btnSelectGif_Click);
            // 
            // txtGifPath
            // 
            this.txtGifPath.Location = new System.Drawing.Point(109, 179);
            this.txtGifPath.Name = "txtGifPath";
            this.txtGifPath.ReadOnly = true;
            this.txtGifPath.Size = new System.Drawing.Size(180, 20);
            this.txtGifPath.TabIndex = 1;
            // 
            // btnSelectAudio
            // 
            this.btnSelectAudio.BackColor = System.Drawing.Color.Black;
            this.btnSelectAudio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAudio.ForeColor = System.Drawing.Color.White;
            this.btnSelectAudio.Location = new System.Drawing.Point(445, 133);
            this.btnSelectAudio.Name = "btnSelectAudio";
            this.btnSelectAudio.Size = new System.Drawing.Size(180, 40);
            this.btnSelectAudio.TabIndex = 2;
            this.btnSelectAudio.Text = "Seleccionar Audio...";
            this.btnSelectAudio.UseVisualStyleBackColor = false;
            this.btnSelectAudio.Click += new System.EventHandler(this.btnSelectAudio_Click);
            // 
            // txtAudioPath
            // 
            this.txtAudioPath.Location = new System.Drawing.Point(445, 179);
            this.txtAudioPath.Name = "txtAudioPath";
            this.txtAudioPath.ReadOnly = true;
            this.txtAudioPath.Size = new System.Drawing.Size(180, 20);
            this.txtAudioPath.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(282, 253);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(165, 66);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "GENERAR VIDEO";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(350, 322);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(32, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Listo.";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(109, 365);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(516, 23);
            this.progressBar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtAudioPath);
            this.Controls.Add(this.btnSelectAudio);
            this.Controls.Add(this.txtGifPath);
            this.Controls.Add(this.btnSelectGif);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectGif;
        private System.Windows.Forms.TextBox txtGifPath;
        private System.Windows.Forms.Button btnSelectAudio;
        private System.Windows.Forms.TextBox txtAudioPath;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

