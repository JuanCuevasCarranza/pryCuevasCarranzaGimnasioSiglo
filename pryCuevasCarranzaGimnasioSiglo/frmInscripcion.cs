using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryCuevasCarranzaGimnasioSiglo
{
    public partial class frmInscripcion : Form
    {

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            // Vaciar cajas de texto
            txtNombre.Clear();
            txtEdad.Clear();

            // Configurar valores iniciales estándar
            txtMeses.Text = "1";
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;

            // Seleccionar por defecto el primer elemento de los ComboBox (si tienen elementos)
            if (cboPlan.Items.Count > 0) cboPlan.SelectedIndex = 0;
            if (cboTurno.Items.Count > 0) cboTurno.SelectedIndex = 0;

            // Configurar la forma de pago (Efectivo marcado por defecto)
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1; // Sin selección
            cboCuotas.Enabled = false;   // Deshabilitado porque está en Efectivo

            // Deshabilitar el botón calcular inicialmente
            btnCalcular.Enabled = false;

            // Dejar el cursor (foco) listo para escribir en el nombre
            txtNombre.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPregunta_Click(object sender, EventArgs e)
        {

        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void cboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbxFormaDePago_Enter(object sender, EventArgs e)
        {

        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void tbpDatosPersonales_Click(object sender, EventArgs e)
        {

        }

        private void gbxPlan_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCasillero_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }
    }
}
