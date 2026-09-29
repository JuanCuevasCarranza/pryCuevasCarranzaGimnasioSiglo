namespace pryCuevasCarranzaGimnasioSiglo
{
    partial class frmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            gbxDatosPersonales = new GroupBox();
            chkEstudiante = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            gbxPlan = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            gbxFormaDePago = new GroupBox();
            gbxDatosPersonales.SuspendLayout();
            gbxPlan.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDatosPersonales
            // 
            gbxDatosPersonales.Controls.Add(chkEstudiante);
            gbxDatosPersonales.Controls.Add(textBox2);
            gbxDatosPersonales.Controls.Add(textBox1);
            gbxDatosPersonales.Location = new Point(0, 0);
            gbxDatosPersonales.Name = "gbxDatosPersonales";
            gbxDatosPersonales.Size = new Size(212, 201);
            gbxDatosPersonales.TabIndex = 0;
            gbxDatosPersonales.TabStop = false;
            gbxDatosPersonales.Text = "Datos Personales";
            gbxDatosPersonales.Enter += groupBox1_Enter;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(106, 93);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 2;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // gbxPlan
            // 
            gbxPlan.Controls.Add(comboBox2);
            gbxPlan.Controls.Add(comboBox1);
            gbxPlan.Location = new Point(218, 0);
            gbxPlan.Name = "gbxPlan";
            gbxPlan.Size = new Size(200, 201);
            gbxPlan.TabIndex = 1;
            gbxPlan.TabStop = false;
            gbxPlan.Text = "Plan";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // gbxFormaDePago
            // 
            gbxFormaDePago.Location = new Point(424, 0);
            gbxFormaDePago.Name = "gbxFormaDePago";
            gbxFormaDePago.Size = new Size(206, 201);
            gbxFormaDePago.TabIndex = 2;
            gbxFormaDePago.TabStop = false;
            gbxFormaDePago.Text = "Forma De Pago";
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 333);
            Controls.Add(gbxFormaDePago);
            Controls.Add(gbxPlan);
            Controls.Add(gbxDatosPersonales);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            gbxDatosPersonales.ResumeLayout(false);
            gbxDatosPersonales.PerformLayout();
            gbxPlan.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDatosPersonales;
        private GroupBox gbxPlan;
        private GroupBox gbxFormaDePago;
        private CheckBox chkEstudiante;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}