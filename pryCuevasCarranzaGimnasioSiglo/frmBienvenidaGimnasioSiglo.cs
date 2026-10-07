using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryCuevasCarranzaGimnasioSiglo
{
    public partial class frmBienvenidaGimnasioSiglo : Form
    {
        public frmBienvenidaGimnasioSiglo()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide(); 

            frmInscripcion f = new frmInscripcion();
            f.ShowDialog(); 

            this.Show(); 
        }
    }
}
