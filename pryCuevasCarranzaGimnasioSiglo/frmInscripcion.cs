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
        // Constantes de la aplicación (Paso 9)
        public const decimal PRECIO_MUSCULACION = 15000m;
        public const decimal PRECIO_FUNCIONAL = 18000m;
        public const decimal PRECIO_NATACION = 22000m;
        public const decimal PRECIO_CASILLERO = 3000m;
        public const int EDAD_MINIMA = 14;
        public const decimal RECARGO_SEIS_CUOTAS = 0.20m;
        public frmInscripcion()
        {
            InitializeComponent();
        }

        public class Configuracion
        {

        }

        private void EstadoInicial(object sender, EventArgs e)
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
            EstadoInicial(sender, e);

            // Vinculamos el evento KeyPress manualmente aquí:
            txtNombre.KeyPress += txtNombre_KeyPress;

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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Convertimos los textos ingresados a números
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            // Validación de la edad mínima (14 años)
            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("El socio es menor de edad mínima (14 años). No puede inscribirse.",
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Corta el cálculo y sale del método
            }

            // Validación del rango de meses (entre 1 y 12) usando operadores lógicos
            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar comprendida entre 1 y 12.",
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Corta el cálculo y sale del método
            }

            // Variables para los siguientes cálculos...
            decimal precioMensual = 0m;
            decimal subtotal = 0m;
            decimal porcentajeDescuento = 0m;
            decimal porcentajeAjustePago = 0m;
            decimal total = 0m;
            decimal valorCuota = 0m;


            string planElegido = cboPlan.SelectedItem?.ToString()?.Trim() ?? "";
            string planLower = planElegido.ToLower();

            if (planLower.Contains("musculaci") || planLower.Contains("musculacin"))
            {
                precioMensual = PRECIO_MUSCULACION;
                planElegido = "Musculación"; // Normalizamos el nombre para el struct
            }
            else if (planLower.Contains("funcional"))
            {
                precioMensual = PRECIO_FUNCIONAL;
                planElegido = "Funcional";
            }
            else if (planLower.Contains("nataci") || planLower.Contains("natacin"))
            {
                precioMensual = PRECIO_NATACION;
                planElegido = "Natación";
            }
            else
            {
                MessageBox.Show($"Plan inválido ('{planElegido}'). Revisa los ítems del ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Horario según el turno (switch con int usando la posición seleccionada)
            string horarioTurno = "";
            int indiceTurno = cboTurno.SelectedIndex;

            switch (indiceTurno)
            {
                case 0:
                    horarioTurno = "7 a 12 h"; // Mañana
                    break;
                case 1:
                    horarioTurno = "14 a 18 h"; // Tarde
                    break;
                case 2:
                    horarioTurno = "18 a 23 h"; // Noche
                    break;
                default:
                    horarioTurno = "Turno no especificado";
                    break;
            }

            // Casillero: if en un solo renglón (sin llaves)
            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;

            // Calculamos el subtotal (precio mensual con casillero incluido, por cantidad de meses)
            subtotal = precioMensual * meses;

            // Descuento por edad o estudiante: if anidado
            // Menor de 18 años: 25% de descuento
            if (edad < 18)
            {
                porcentajeDescuento = 0.25m;
            }
            else
            {
                // Si no es menor de 18, anidamos otro if-else
                // 65 años o más: 30% de descuento
                if (edad >= 65)
                {
                    porcentajeDescuento = 0.30m;
                }
                else
                {
                    // Tercer nivel: si no es jubilado, preguntamos si es estudiante (15% o 0%)
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

            // Descuento o recargo según la forma de pago (¡Aquí estaba el else suelto!)
            if (rbtEfectivo.Checked)
            {
                porcentajeAjustePago = -0.10m; // 10% de descuento en efectivo
            }
            else
            {
                // Tarjeta: convertimos la cantidad de cuotas elegida a entero de forma segura
                int cuotas = int.Parse(cboCuotas.SelectedItem?.ToString() ?? "1");

                // Cadena de if - else if para asignar el recargo según las cuotas
                if (cuotas == 1)
                {
                    porcentajeAjustePago = 0.0m; // 1 cuota sin recargo
                }
                else if (cuotas == 3)
                {
                    porcentajeAjustePago = 0.10m; // 3 cuotas +10%
                }
                else if (cuotas == 6)
                {
                    porcentajeAjustePago = RECARGO_SEIS_CUOTAS; // 6 cuotas +20% (usando la constante)
                }
            }

            // Calculamos el monto intermedio aplicando el descuento por edad/estudiante
            decimal subtotalConDescuentoEdad = subtotal - (subtotal * porcentajeDescuento);

            // Calculamos el total final aplicando el ajuste por la forma de pago (descuento o recargo)
            total = subtotalConDescuentoEdad + (subtotalConDescuentoEdad * porcentajeAjustePago);

            // Categoría del socio ("Menor" si es menor de 18, caso contrario "Mayor")
            string categoria = (edad < 18) ? "Menor" : "Mayor";

            // Texto de la forma de pago de forma segura
            string formaPagoTexto = rbtEfectivo.Checked ? "Efectivo" : $"Tarjeta en {cboCuotas.SelectedItem?.ToString() ?? "1"} cuotas";

            // Valor de cada cuota de forma segura
            int cuotasElegidas = rbtEfectivo.Checked ? 1 : int.Parse(cboCuotas.SelectedItem?.ToString() ?? "1");
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

            // Mostrar resultados utilizando los datos del struct
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
        }

        private void lblCuotas_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial(sender, e);
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si no es un dígito y tampoco es la tecla Backspace (borrar)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Descarta la tecla
            }
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Descarta la tecla
            }
        }

        private void txtNombre_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Si la tecla presionada no es una letra, ni un espacio, ni la tecla Backspace (borrar)
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Descarta la tecla y no deja escribirla
            }
            else
            {
                // Si es una letra minúscula, la convertimos a mayúscula automáticamente
                if (char.IsLower(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
            }
        }

        private void frmInscripcion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
