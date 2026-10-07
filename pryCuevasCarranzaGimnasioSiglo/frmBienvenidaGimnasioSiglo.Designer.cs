namespace pryCuevasCarranzaGimnasioSiglo
{
    partial class frmBienvenidaGimnasioSiglo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenidaGimnasioSiglo));
            pbx4 = new PictureBox();
            btnRegistrarse = new Button();
            ((System.ComponentModel.ISupportInitialize)pbx4).BeginInit();
            SuspendLayout();
            // 
            // pbx4
            // 
            pbx4.BackgroundImage = Properties.Resources.images__4_;
            pbx4.Location = new Point(-1, 0);
            pbx4.Name = "pbx4";
            pbx4.Size = new Size(461, 442);
            pbx4.SizeMode = PictureBoxSizeMode.CenterImage;
            pbx4.TabIndex = 0;
            pbx4.TabStop = false;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = SystemColors.ControlLightLight;
            btnRegistrarse.Image = Properties.Resources.images1;
            btnRegistrarse.Location = new Point(-1, 426);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(461, 68);
            btnRegistrarse.TabIndex = 1;
            btnRegistrarse.Text = "[¡&REGISTRATE!]";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // frmBienvenidaGimnasioSiglo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(458, 493);
            Controls.Add(btnRegistrarse);
            Controls.Add(pbx4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBienvenidaGimnasioSiglo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GIMNASIO SIGLO - INSCRIPCION";
            ((System.ComponentModel.ISupportInitialize)pbx4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbx4;
        private Button btnRegistrarse;
    }
}