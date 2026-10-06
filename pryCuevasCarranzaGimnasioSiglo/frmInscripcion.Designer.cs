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
            pictureBox1 = new PictureBox();
            lblPregunta = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            chkEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            gbxPlan = new GroupBox();
            pictureBox2 = new PictureBox();
            lblCasillero = new Label();
            chkCasillero = new CheckBox();
            lblMeses = new Label();
            txtMeses = new TextBox();
            lblTurno = new Label();
            lblPlan = new Label();
            cboTurno = new ComboBox();
            cboPlan = new ComboBox();
            gbxFormaDePago1 = new GroupBox();
            pictureBox3 = new PictureBox();
            btnCalcular = new Button();
            lblCuotas = new Label();
            cboCuotas = new ComboBox();
            gbxFormaDePago2 = new GroupBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            btnLimpiar = new Button();
            tbcMenuPrincipal = new TabControl();
            tbpDatosPersonales = new TabPage();
            tbpPlan = new TabPage();
            tbpFormasDePago = new TabPage();
            gbxDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbxPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbxFormaDePago1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            gbxFormaDePago2.SuspendLayout();
            tbcMenuPrincipal.SuspendLayout();
            tbpDatosPersonales.SuspendLayout();
            tbpPlan.SuspendLayout();
            tbpFormasDePago.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDatosPersonales
            // 
            gbxDatosPersonales.BackColor = Color.Transparent;
            gbxDatosPersonales.Controls.Add(pictureBox1);
            gbxDatosPersonales.Controls.Add(lblPregunta);
            gbxDatosPersonales.Controls.Add(lblEdad);
            gbxDatosPersonales.Controls.Add(lblNombre);
            gbxDatosPersonales.Controls.Add(chkEstudiante);
            gbxDatosPersonales.Controls.Add(txtEdad);
            gbxDatosPersonales.Controls.Add(txtNombre);
            gbxDatosPersonales.Location = new Point(0, 0);
            gbxDatosPersonales.Name = "gbxDatosPersonales";
            gbxDatosPersonales.Size = new Size(252, 245);
            gbxDatosPersonales.TabIndex = 0;
            gbxDatosPersonales.TabStop = false;
            gbxDatosPersonales.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(6, 95);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(96, 15);
            lblPregunta.TabIndex = 3;
            lblPregunta.Text = "¿Eres estudiante?";
            lblPregunta.Click += lblPregunta_Click;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(24, 62);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            lblEdad.Click += lblEdad_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(117, 95);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(35, 19);
            chkEstudiante.TabIndex = 3;
            chkEstudiante.Text = "Sí";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(77, 54);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(34, 23);
            txtEdad.TabIndex = 2;
            txtEdad.TextChanged += txtEdad_TextChanged;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(77, 16);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(132, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // gbxPlan
            // 
            gbxPlan.BackColor = Color.White;
            gbxPlan.Controls.Add(pictureBox2);
            gbxPlan.Controls.Add(lblCasillero);
            gbxPlan.Controls.Add(chkCasillero);
            gbxPlan.Controls.Add(lblMeses);
            gbxPlan.Controls.Add(txtMeses);
            gbxPlan.Controls.Add(lblTurno);
            gbxPlan.Controls.Add(lblPlan);
            gbxPlan.Controls.Add(cboTurno);
            gbxPlan.Controls.Add(cboPlan);
            gbxPlan.Location = new Point(6, -5);
            gbxPlan.Name = "gbxPlan";
            gbxPlan.Size = new Size(248, 253);
            gbxPlan.TabIndex = 1;
            gbxPlan.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images__6_;
            pictureBox2.Location = new Point(7, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // lblCasillero
            // 
            lblCasillero.AutoSize = true;
            lblCasillero.Location = new Point(91, 93);
            lblCasillero.Name = "lblCasillero";
            lblCasillero.Size = new Size(87, 15);
            lblCasillero.TabIndex = 0;
            lblCasillero.Text = "¿Con Casillero?";
            lblCasillero.Click += lblCasillero_Click;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(91, 111);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 0;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            chkCasillero.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(4, 102);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(40, 15);
            lblMeses.TabIndex = 1;
            lblMeses.Text = "Meses";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(50, 99);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(35, 23);
            txtMeses.TabIndex = 2;
            txtMeses.TextChanged += ValidarCamposCompletos;
            txtMeses.KeyPress += txtMeses_KeyPress;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(7, 56);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(38, 15);
            lblTurno.TabIndex = 7;
            lblTurno.Text = "Turno";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(11, 19);
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
            cboTurno.Location = new Point(50, 53);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 7;
            cboTurno.SelectedIndexChanged += cboTurno_SelectedIndexChanged;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación ", "Funcional ", "Natación" });
            cboPlan.Location = new Point(50, 16);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 5;
            // 
            // gbxFormaDePago1
            // 
            gbxFormaDePago1.Controls.Add(pictureBox3);
            gbxFormaDePago1.Controls.Add(btnCalcular);
            gbxFormaDePago1.Controls.Add(lblCuotas);
            gbxFormaDePago1.Controls.Add(cboCuotas);
            gbxFormaDePago1.Controls.Add(gbxFormaDePago2);
            gbxFormaDePago1.Location = new Point(3, 0);
            gbxFormaDePago1.Name = "gbxFormaDePago1";
            gbxFormaDePago1.Size = new Size(245, 186);
            gbxFormaDePago1.TabIndex = 2;
            gbxFormaDePago1.TabStop = false;
            gbxFormaDePago1.Enter += gbxFormaDePago_Enter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.images__7_;
            pictureBox3.Location = new Point(6, 109);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(230, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(117, 55);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 39);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(117, 23);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 6;
            lblCuotas.Text = "Cuotas";
            lblCuotas.Click += lblCuotas_Click;
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(167, 20);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(69, 23);
            cboCuotas.TabIndex = 1;
            // 
            // gbxFormaDePago2
            // 
            gbxFormaDePago2.Controls.Add(rbtTarjeta);
            gbxFormaDePago2.Controls.Add(rbtEfectivo);
            gbxFormaDePago2.Location = new Point(6, 15);
            gbxFormaDePago2.Name = "gbxFormaDePago2";
            gbxFormaDePago2.Size = new Size(105, 88);
            gbxFormaDePago2.TabIndex = 4;
            gbxFormaDePago2.TabStop = false;
            gbxFormaDePago2.Text = "Forma De Pago";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(6, 60);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(59, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(6, 30);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(3, 186);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(245, 62);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // tbcMenuPrincipal
            // 
            tbcMenuPrincipal.Controls.Add(tbpDatosPersonales);
            tbcMenuPrincipal.Controls.Add(tbpPlan);
            tbcMenuPrincipal.Controls.Add(tbpFormasDePago);
            tbcMenuPrincipal.Location = new Point(27, 21);
            tbcMenuPrincipal.Name = "tbcMenuPrincipal";
            tbcMenuPrincipal.SelectedIndex = 0;
            tbcMenuPrincipal.Size = new Size(262, 279);
            tbcMenuPrincipal.TabIndex = 0;
            // 
            // tbpDatosPersonales
            // 
            tbpDatosPersonales.Controls.Add(gbxDatosPersonales);
            tbpDatosPersonales.Location = new Point(4, 24);
            tbpDatosPersonales.Name = "tbpDatosPersonales";
            tbpDatosPersonales.Padding = new Padding(3);
            tbpDatosPersonales.Size = new Size(254, 251);
            tbpDatosPersonales.TabIndex = 0;
            tbpDatosPersonales.Text = "Datos Personales";
            tbpDatosPersonales.UseVisualStyleBackColor = true;
            tbpDatosPersonales.Click += tbpDatosPersonales_Click;
            // 
            // tbpPlan
            // 
            tbpPlan.BackColor = Color.Transparent;
            tbpPlan.Controls.Add(gbxPlan);
            tbpPlan.Location = new Point(4, 24);
            tbpPlan.Name = "tbpPlan";
            tbpPlan.Padding = new Padding(3);
            tbpPlan.Size = new Size(254, 251);
            tbpPlan.TabIndex = 1;
            tbpPlan.Text = "Plan";
            // 
            // tbpFormasDePago
            // 
            tbpFormasDePago.Controls.Add(gbxFormaDePago1);
            tbpFormasDePago.Controls.Add(btnLimpiar);
            tbpFormasDePago.Location = new Point(4, 24);
            tbpFormasDePago.Name = "tbpFormasDePago";
            tbpFormasDePago.Size = new Size(254, 251);
            tbpFormasDePago.TabIndex = 2;
            tbpFormasDePago.Text = "Formas De Pago";
            tbpFormasDePago.UseVisualStyleBackColor = true;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(315, 323);
            Controls.Add(tbcMenuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            Load += EstadoInicial;
            gbxDatosPersonales.ResumeLayout(false);
            gbxDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbxPlan.ResumeLayout(false);
            gbxPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbxFormaDePago1.ResumeLayout(false);
            gbxFormaDePago1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            gbxFormaDePago2.ResumeLayout(false);
            gbxFormaDePago2.PerformLayout();
            tbcMenuPrincipal.ResumeLayout(false);
            tbpDatosPersonales.ResumeLayout(false);
            tbpPlan.ResumeLayout(false);
            tbpFormasDePago.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDatosPersonales;
        private GroupBox gbxPlan;
        private GroupBox gbxFormaDePago1;
        private CheckBox chkEstudiante;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private ComboBox cboTurno;
        private ComboBox cboPlan;
        private Label lblEdad;
        private Label lblNombre;
        private TabControl tbcMenuPrincipal;
        private TabPage tbpDatosPersonales;
        private TabPage tbpPlan;
        private TabPage tbpFormasDePago;
        private Label lblPregunta;
        private Label lblTurno;
        private Label lblPlan;
        private TextBox txtMeses;
        private Label lblMeses;
        private GroupBox gbxFormaDePago2;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private PictureBox pictureBox1;
        private CheckBox chkCasillero;
        private ComboBox cboCuotas;
        private Label lblCasillero;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Label lblCuotas;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}