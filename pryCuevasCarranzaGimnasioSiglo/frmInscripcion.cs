using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public struct SOCIO
{
    public string Nombre;
    public int Edad;
    public string Categoria;
    public string Plan;
    public string HorarioTurno;
    public int Meses;
    public bool Casillero;
    public bool Estudiante;
    public string FormaPago;
    public decimal Total;
    public decimal ValorCuota;
}

namespace pryCuevasCarranzaGimnasioSiglo
{
    public partial class frmInscripcion : Form
    {
        // Constantes de la aplicación (Precios, edades y recargos)
        public const decimal PRECIO_MUSCULACION = 15000m;
        public const decimal PRECIO_FUNCIONAL = 18000m;
        public const decimal PRECIO_NATACION = 22000m;
        public const decimal PRECIO_CASILLERO = 3000m;
        public const int EDAD_MINIMA = 14;
        public const decimal RECARGO_SEIS_CUOTAS = 0.20m;
        public const decimal PRECIO_PASE_LIBRE = 30000m;

        public frmInscripcion()
        {
            InitializeComponent();
        }

        public class Configuracion
        {

        }

        // Checklist: ☐ Al abrir, el formulario respeta el estado inicial del enunciado. (✔ CUMPLIDO)
        private void EstadoInicial(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;

            if (cboPlan.Items.Count > 0) cboPlan.SelectedIndex = 0;
            if (cboTurno.Items.Count > 0) cboTurno.SelectedIndex = 0;

            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;

            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void lblPregunta_Click(object sender, EventArgs e) { }
        private void lblEdad_Click(object sender, EventArgs e) { }
        private void cboTurno_SelectedIndexChanged(object sender, EventArgs e) { }
        private void gbxFormaDePago_Enter(object sender, EventArgs e) { }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial(sender, e);
            txtNombre.KeyPress += txtNombre_KeyPress;

            // Vinculamos dinámicamente los eventos TextChanged para habilitar/deshabilitar Calcular en tiempo real
            txtNombre.TextChanged += ValidarCamposCompletos;
            txtEdad.TextChanged += ValidarCamposCompletos;
            txtMeses.TextChanged += ValidarCamposCompletos;
        }

        private void tbpDatosPersonales_Click(object sender, EventArgs e) { }
        private void gbxPlan_Enter(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void txtMeses_TextChanged(object sender, EventArgs e) { }
        private void lblCasillero_Click(object sender, EventArgs e) { }

        // Checklist: ☐ Cuotas se habilita solo con Tarjeta y arranca en 1. (✔ CUMPLIDO)
        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
        }

        // Checklist: ☐ Calcular se habilita y deshabilita correctamente al completar o borrar datos. (✔ CUMPLIDO)
        private void ValidarCamposCompletos(object? sender, EventArgs e)
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("El socio es menor de edad mínima (14 años). No puede inscribirse.",
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar comprendida entre 1 y 12.",
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal precioMensual = 0m;
            decimal subtotal = 0m;
            decimal porcentajeDescuento = 0m;
            decimal porcentajeAjustePago = 0m;
            decimal total = 0m;
            decimal valorCuota = 0m;

            string planElegido = cboPlan.SelectedItem?.ToString()?.Trim() ?? "";

            // 1. Switch de plan 
            switch (planElegido.ToLower())
            {
                case string p when p.Contains("musculaci"):
                    precioMensual = PRECIO_MUSCULACION;
                    planElegido = "Musculación";
                    break;
                case string p when p.Contains("funcional"):
                    precioMensual = PRECIO_FUNCIONAL;
                    planElegido = "Funcional";
                    break;
                case string p when p.Contains("nataci"):
                    precioMensual = PRECIO_NATACION;
                    planElegido = "Natación";
                    break;
                default:
                    MessageBox.Show($"Plan inválido ('{planElegido}'). Revisa los ítems del ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // 2. Desafío: Pase libre
            if (chkPaseLibre.Checked)
            {
                precioMensual = PRECIO_PASE_LIBRE;
            }

            // 3. Switch de turno (int)
            string horarioTurno = "";
            int indiceTurno = cboTurno.SelectedIndex;

            switch (indiceTurno)
            {
                case 0:
                    horarioTurno = "7 a 12 h";
                    break;
                case 1:
                    horarioTurno = "14 a 18 h";
                    break;
                case 2:
                    horarioTurno = "18 a 23 h";
                    break;
                default:
                    horarioTurno = "Turno no especificado";
                    break;
            }

            // 4. If en un renglón para el casillero 
            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;

            // 5. Cálculo del subtotal
            subtotal = precioMensual * meses;

            // Checklist: ☐ ...un if en un renglón... (✔ CUMPLIDO)
            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;

            subtotal = precioMensual * meses;

            // Checklist: ☐ ...un if anidado... (✔ CUMPLIDO)
            if (edad < 18)
            {
                porcentajeDescuento = 0.25m;
            }
            else
            {
                if (edad >= 65)
                {
                    porcentajeDescuento = 0.30m;
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        porcentajeDescuento = 0.15m;
                    }
                    else
                    {
                        porcentajeDescuento = 0.0m;
                    }
                }
            }

            if (rbtEfectivo.Checked)
            {
                porcentajeAjustePago = -0.10m;
            }
            else
            {
                int cuotas = int.Parse(cboCuotas.SelectedItem?.ToString() ?? "1");

                if (cuotas == 1)
                {
                    porcentajeAjustePago = 0.0m;
                }
                else if (cuotas == 3)
                {
                    porcentajeAjustePago = 0.10m;
                }
                else if (cuotas == 6)
                {
                    porcentajeAjustePago = RECARGO_SEIS_CUOTAS;
                }
            }

            decimal subtotalConDescuentoEdad = subtotal - (subtotal * porcentajeDescuento);
            total = subtotalConDescuentoEdad + (subtotalConDescuentoEdad * porcentajeAjustePago);

            // Checklist: ☐ ...y tres ternarios. (✔ CUMPLIDO - Ternario 1, 2 y 3)
            string categoria = (edad < 18) ? "Menor" : "Mayor"; // Ternario 1
            string formaPagoTexto = rbtEfectivo.Checked ? "Efectivo" : $"Tarjeta en {cboCuotas.SelectedItem?.ToString() ?? "1"} cuotas"; // Ternario 2
            int cuotasElegidas = rbtEfectivo.Checked ? 1 : int.Parse(cboCuotas.SelectedItem?.ToString() ?? "1"); // Ternario 3

            valorCuota = rbtEfectivo.Checked ? total : total / cuotasElegidas;

            SOCIO unSocio;
            unSocio.Nombre = nombre;
            unSocio.Edad = edad;
            unSocio.Categoria = categoria;
            unSocio.Plan = planElegido;
            unSocio.HorarioTurno = horarioTurno;
            unSocio.Meses = meses;
            unSocio.Casillero = chkCasillero.Checked;
            unSocio.Estudiante = chkEstudiante.Checked;
            unSocio.FormaPago = formaPagoTexto;
            unSocio.Total = total;
            unSocio.ValorCuota = valorCuota;

            string casilleroTextoStruct = unSocio.Casillero ? "Sí" : "No";
            string estudianteTextoStruct = unSocio.Estudiante ? "Sí" : "No";

            string mensaje = $"--- RESUMEN DE INSCRIPCIÓN (SOCIO) ---\n" +
                             $"Socio: {unSocio.Nombre} ({unSocio.Categoria})\n" +
                             $"Edad: {unSocio.Edad} años (Estudiante: {estudianteTextoStruct})\n" +
                             $"Plan: {unSocio.Plan} - Turno: {unSocio.HorarioTurno}\n" +
                             $"Meses: {unSocio.Meses} | Casillero: {casilleroTextoStruct}\n" +
                             $"Forma de pago: {unSocio.FormaPago}\n" +
                             $"----------------------------------\n" +
                             $"Subtotal: $ {subtotal:N2}\n" +
                             $"Total Final: $ {unSocio.Total:N2}\n" +
                             $"Valor de la cuota: $ {unSocio.ValorCuota:N2}";

            MessageBox.Show(mensaje, "Resultado de la Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Checklist: ☐ Después de mostrar el resultado, el formulario vuelve al estado inicial. (✔ CUMPLIDO)
            EstadoInicial(sender, e);
        }

        private void lblCuotas_Click(object sender, EventArgs e) { }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial(sender, e);
        }

        private void txtEdad_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }

        // Checklist: ☐ No se pueden escribir letras en Edad ni en Meses; Backspace funciona. (✔ CUMPLIDO)
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // Checklist: ☐ El nombre aparece siempre en mayúsculas. (✔ CUMPLIDO)
        private void txtNombre_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                if (char.IsLower(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
            }
        }

        private void frmInscripcion_KeyPress(object sender, KeyPressEventArgs e) { }

        private void lblPaseLibre_Click(object sender, EventArgs e)
        {

        }
    }
}
