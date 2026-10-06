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
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;

            // Selecciona el primer elemento de los ComboBox si contienen elementos
            if (cboPlan.Items.Count > 0) cboPlan.SelectedIndex = 0;
            if (cboTurno.Items.Count > 0) cboTurno.SelectedIndex = 0;

            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1; // Sin selección
            cboCuotas.Enabled = false;   // Deshabilitado por defecto

            btnCalcular.Enabled = false; // Deshabilitado hasta que se llenen los campos obligatorios
            txtNombre.Focus();           // Deja el cursor listo para escribir
        }

        // Invocación desde el evento Load del formulario (Paso 7)

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
            // (Asegúrate de agregar aquí los ítems de tus ComboBox si no los cargaste desde el diseñador)
            EstadoInicial();
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

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0; // Selecciona 1 cuota por defecto
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1; // Sin selección y deshabilitado
            }
        }
        private void ValidarCamposCompletos(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "" && txtEdad.Text.Trim() != "" && txtMeses.Text.Trim() != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

    }
}
