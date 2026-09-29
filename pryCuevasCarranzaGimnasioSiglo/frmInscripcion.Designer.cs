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
            lblPregunta = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            chkEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            gbxPlan = new GroupBox();
            label2 = new Label();
            lblPlan = new Label();
            cboTurno = new ComboBox();
            cboPlan = new ComboBox();
            gbxFormaDePago = new GroupBox();
            tbcMenuPrincipal = new TabControl();
            tbpPagina1 = new TabPage();
            tbpPagina2 = new TabPage();
            tbpPagina3 = new TabPage();
            gbxDatosPersonales.SuspendLayout();
            gbxPlan.SuspendLayout();
            tbcMenuPrincipal.SuspendLayout();
            tbpPagina1.SuspendLayout();
            tbpPagina2.SuspendLayout();
            tbpPagina3.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDatosPersonales
            // 
            gbxDatosPersonales.Controls.Add(lblPregunta);
            gbxDatosPersonales.Controls.Add(lblEdad);
            gbxDatosPersonales.Controls.Add(lblNombre);
            gbxDatosPersonales.Controls.Add(chkEstudiante);
            gbxDatosPersonales.Controls.Add(txtEdad);
            gbxDatosPersonales.Controls.Add(txtNombre);
            gbxDatosPersonales.Location = new Point(6, 6);
            gbxDatosPersonales.Name = "gbxDatosPersonales";
            gbxDatosPersonales.Size = new Size(206, 139);
            gbxDatosPersonales.TabIndex = 0;
            gbxDatosPersonales.TabStop = false;
            gbxDatosPersonales.Text = "Datos Personales";
            gbxDatosPersonales.Enter += groupBox1_Enter;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(6, 98);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(96, 15);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = "¿Eres estudiante?";
            lblPregunta.Click += lblPregunta_Click;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(11, 62);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(2, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(108, 98);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 2;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(68, 54);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(34, 23);
            txtEdad.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(68, 25);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(132, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // gbxPlan
            // 
            gbxPlan.Controls.Add(label2);
            gbxPlan.Controls.Add(lblPlan);
            gbxPlan.Controls.Add(cboTurno);
            gbxPlan.Controls.Add(cboPlan);
            gbxPlan.Location = new Point(6, 6);
            gbxPlan.Name = "gbxPlan";
            gbxPlan.Size = new Size(200, 139);
            gbxPlan.TabIndex = 1;
            gbxPlan.TabStop = false;
            gbxPlan.Text = "Plan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Turno";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(6, 25);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 5;
            lblPlan.Text = "Plan";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana ", "Tarde", "Noche" });
            cboTurno.Location = new Point(51, 56);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 4;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación ", "Funcional ", "Natación" });
            cboPlan.Location = new Point(42, 22);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 3;
            // 
            // gbxFormaDePago
            // 
            gbxFormaDePago.Location = new Point(3, 3);
            gbxFormaDePago.Name = "gbxFormaDePago";
            gbxFormaDePago.Size = new Size(206, 145);
            gbxFormaDePago.TabIndex = 2;
            gbxFormaDePago.TabStop = false;
            gbxFormaDePago.Text = "Forma De Pago";
            // 
            // tbcMenuPrincipal
            // 
            tbcMenuPrincipal.Controls.Add(tbpPagina1);
            tbcMenuPrincipal.Controls.Add(tbpPagina2);
            tbcMenuPrincipal.Controls.Add(tbpPagina3);
            tbcMenuPrincipal.Location = new Point(12, -2);
            tbcMenuPrincipal.Name = "tbcMenuPrincipal";
            tbcMenuPrincipal.SelectedIndex = 0;
            tbcMenuPrincipal.Size = new Size(229, 179);
            tbcMenuPrincipal.TabIndex = 0;
            // 
            // tbpPagina1
            // 
            tbpPagina1.Controls.Add(gbxDatosPersonales);
            tbpPagina1.Location = new Point(4, 24);
            tbpPagina1.Name = "tbpPagina1";
            tbpPagina1.Padding = new Padding(3);
            tbpPagina1.Size = new Size(221, 151);
            tbpPagina1.TabIndex = 0;
            tbpPagina1.Text = "Sección 1";
            tbpPagina1.UseVisualStyleBackColor = true;
            // 
            // tbpPagina2
            // 
            tbpPagina2.Controls.Add(gbxPlan);
            tbpPagina2.Location = new Point(4, 24);
            tbpPagina2.Name = "tbpPagina2";
            tbpPagina2.Padding = new Padding(3);
            tbpPagina2.Size = new Size(221, 151);
            tbpPagina2.TabIndex = 1;
            tbpPagina2.Text = "Sección 2";
            tbpPagina2.UseVisualStyleBackColor = true;
            // 
            // tbpPagina3
            // 
            tbpPagina3.Controls.Add(gbxFormaDePago);
            tbpPagina3.Location = new Point(4, 24);
            tbpPagina3.Name = "tbpPagina3";
            tbpPagina3.Size = new Size(221, 151);
            tbpPagina3.TabIndex = 2;
            tbpPagina3.Text = "Sección 3";
            tbpPagina3.UseVisualStyleBackColor = true;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 192);
            Controls.Add(tbcMenuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            gbxDatosPersonales.ResumeLayout(false);
            gbxDatosPersonales.PerformLayout();
            gbxPlan.ResumeLayout(false);
            gbxPlan.PerformLayout();
            tbcMenuPrincipal.ResumeLayout(false);
            tbpPagina1.ResumeLayout(false);
            tbpPagina2.ResumeLayout(false);
            tbpPagina3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDatosPersonales;
        private GroupBox gbxPlan;
        private GroupBox gbxFormaDePago;
        private CheckBox chkEstudiante;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private ComboBox cboTurno;
        private ComboBox cboPlan;
        private Label lblEdad;
        private Label lblNombre;
        private TabControl tbcMenuPrincipal;
        private TabPage tbpPagina1;
        private TabPage tbpPagina2;
        private TabPage tbpPagina3;
        private Label lblPregunta;
        private Label label2;
        private Label lblPlan;
    }
}