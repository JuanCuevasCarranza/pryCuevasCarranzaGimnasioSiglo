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
            textBox1 = new TextBox();
            txtDNI = new TextBox();
            lblDNI = new Label();
            lblApellido = new Label();
            lblPregunta = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            chkEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            gbxPlan = new GroupBox();
            lblPaseLibre = new Label();
            chkPaseLibre = new CheckBox();
            lblCasillero = new Label();
            chkCasillero = new CheckBox();
            lblMeses = new Label();
            txtMeses = new TextBox();
            lblTurno = new Label();
            lblPlan = new Label();
            cboTurno = new ComboBox();
            cboPlan = new ComboBox();
            gbxFormaDePago1 = new GroupBox();
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
            gbxPlan.SuspendLayout();
            gbxFormaDePago1.SuspendLayout();
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
            gbxDatosPersonales.BackgroundImage = Properties.Resources.images__6_;
            gbxDatosPersonales.Controls.Add(textBox1);
            gbxDatosPersonales.Controls.Add(txtDNI);
            gbxDatosPersonales.Controls.Add(lblDNI);
            gbxDatosPersonales.Controls.Add(lblApellido);
            gbxDatosPersonales.Controls.Add(lblPregunta);
            gbxDatosPersonales.Controls.Add(lblEdad);
            gbxDatosPersonales.Controls.Add(lblNombre);
            gbxDatosPersonales.Controls.Add(chkEstudiante);
            gbxDatosPersonales.Controls.Add(txtEdad);
            gbxDatosPersonales.Controls.Add(txtNombre);
            gbxDatosPersonales.Location = new Point(0, -9);
            gbxDatosPersonales.Name = "gbxDatosPersonales";
            gbxDatosPersonales.Size = new Size(258, 260);
            gbxDatosPersonales.TabIndex = 0;
            gbxDatosPersonales.TabStop = false;
            gbxDatosPersonales.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(7, 125);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 6;
            txtDNI.TextChanged += txtDNI_TextChanged;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.ForeColor = SystemColors.Control;
            lblDNI.Location = new Point(6, 107);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 5;
            lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = SystemColors.Control;
            lblApellido.Location = new Point(7, 63);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.ForeColor = SystemColors.Control;
            lblPregunta.Location = new Point(3, 203);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(96, 15);
            lblPregunta.TabIndex = 3;
            lblPregunta.Text = "¿Eres estudiante?";
            lblPregunta.Click += lblPregunta_Click;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.ForeColor = SystemColors.Control;
            lblEdad.Location = new Point(6, 159);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            lblEdad.Click += lblEdad_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.Control;
            lblNombre.Location = new Point(6, 12);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.ForeColor = SystemColors.ControlLight;
            chkEstudiante.Location = new Point(9, 221);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(35, 19);
            chkEstudiante.TabIndex = 3;
            chkEstudiante.Text = "Sí";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(8, 177);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(34, 23);
            txtEdad.TabIndex = 2;
            txtEdad.TextChanged += txtEdad_TextChanged;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(7, 30);
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
            gbxPlan.BackgroundImage = Properties.Resources.images__6_;
            gbxPlan.Controls.Add(lblPaseLibre);
            gbxPlan.Controls.Add(chkPaseLibre);
            gbxPlan.Controls.Add(lblCasillero);
            gbxPlan.Controls.Add(chkCasillero);
            gbxPlan.Controls.Add(lblMeses);
            gbxPlan.Controls.Add(txtMeses);
            gbxPlan.Controls.Add(lblTurno);
            gbxPlan.Controls.Add(lblPlan);
            gbxPlan.Controls.Add(cboTurno);
            gbxPlan.Controls.Add(cboPlan);
            gbxPlan.Location = new Point(3, -9);
            gbxPlan.Name = "gbxPlan";
            gbxPlan.Size = new Size(248, 257);
            gbxPlan.TabIndex = 1;
            gbxPlan.TabStop = false;
            // 
            // lblPaseLibre
            // 
            lblPaseLibre.AutoSize = true;
            lblPaseLibre.BackColor = Color.Transparent;
            lblPaseLibre.ForeColor = SystemColors.Control;
            lblPaseLibre.Location = new Point(3, 151);
            lblPaseLibre.Name = "lblPaseLibre";
            lblPaseLibre.Size = new Size(107, 15);
            lblPaseLibre.TabIndex = 15;
            lblPaseLibre.Text = "¿Tienes Pase Libre?";
            lblPaseLibre.Click += lblPaseLibre_Click;
            // 
            // chkPaseLibre
            // 
            chkPaseLibre.AutoSize = true;
            chkPaseLibre.BackColor = Color.Transparent;
            chkPaseLibre.ForeColor = SystemColors.Control;
            chkPaseLibre.Location = new Point(6, 169);
            chkPaseLibre.Name = "chkPaseLibre";
            chkPaseLibre.Size = new Size(76, 19);
            chkPaseLibre.TabIndex = 14;
            chkPaseLibre.Text = "PaseLibre";
            chkPaseLibre.UseVisualStyleBackColor = false;
            // 
            // lblCasillero
            // 
            lblCasillero.AutoSize = true;
            lblCasillero.BackColor = Color.Transparent;
            lblCasillero.ForeColor = SystemColors.Control;
            lblCasillero.Location = new Point(3, 205);
            lblCasillero.Name = "lblCasillero";
            lblCasillero.Size = new Size(87, 15);
            lblCasillero.TabIndex = 0;
            lblCasillero.Text = "¿Con Casillero?";
            lblCasillero.Click += lblCasillero_Click;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.BackColor = Color.Transparent;
            chkCasillero.ForeColor = SystemColors.Control;
            chkCasillero.Location = new Point(6, 223);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 0;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = false;
            chkCasillero.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.BackColor = Color.Transparent;
            lblMeses.ForeColor = SystemColors.ControlLight;
            lblMeses.Location = new Point(182, 32);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(40, 15);
            lblMeses.TabIndex = 1;
            lblMeses.Text = "Meses";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(182, 54);
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
            lblTurno.BackColor = Color.Transparent;
            lblTurno.ForeColor = SystemColors.Control;
            lblTurno.Location = new Point(15, 73);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 7;
            lblTurno.Text = "Turno";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.BackColor = Color.Transparent;
            lblPlan.ForeColor = SystemColors.Control;
            lblPlan.Location = new Point(15, 35);
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
            cboTurno.Location = new Point(64, 70);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(86, 23);
            cboTurno.TabIndex = 7;
            cboTurno.SelectedIndexChanged += cboTurno_SelectedIndexChanged;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación ", "Funcional ", "Natación" });
            cboPlan.Location = new Point(64, 32);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(86, 23);
            cboPlan.TabIndex = 5;
            // 
            // gbxFormaDePago1
            // 
            gbxFormaDePago1.BackgroundImage = Properties.Resources.images__6_;
            gbxFormaDePago1.Controls.Add(btnCalcular);
            gbxFormaDePago1.Controls.Add(lblCuotas);
            gbxFormaDePago1.Controls.Add(cboCuotas);
            gbxFormaDePago1.Controls.Add(gbxFormaDePago2);
            gbxFormaDePago1.Location = new Point(3, -7);
            gbxFormaDePago1.Name = "gbxFormaDePago1";
            gbxFormaDePago1.Size = new Size(245, 193);
            gbxFormaDePago1.TabIndex = 2;
            gbxFormaDePago1.TabStop = false;
            gbxFormaDePago1.Enter += gbxFormaDePago_Enter;
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
            lblCuotas.ForeColor = SystemColors.Control;
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
            gbxFormaDePago2.ForeColor = SystemColors.Control;
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
            rbtTarjeta.Size = new Size(60, 19);
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
            btnLimpiar.BackgroundImage = Properties.Resources.images__7_;
            btnLimpiar.ForeColor = SystemColors.ControlText;
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
            gbxPlan.ResumeLayout(false);
            gbxPlan.PerformLayout();
            gbxFormaDePago1.ResumeLayout(false);
            gbxFormaDePago1.PerformLayout();
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
        private CheckBox chkCasillero;
        private ComboBox cboCuotas;
        private Label lblCasillero;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Label lblCuotas;
        private CheckBox chkPaseLibre;
        private Label lblPaseLibre;
        private TextBox txtDNI;
        private Label lblDNI;
        private Label lblApellido;
        private TextBox textBox1;
    }
}