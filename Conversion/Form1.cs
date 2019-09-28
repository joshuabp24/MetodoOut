using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class frmConversiones : Form
    {
        public frmConversiones()
        {
            InitializeComponent();
        }

        private void frmConversiones_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            Metodos M = new Metodos();
            int Totalcentavos, pesos = 0, centavo = 0;
            Totalcentavos = Convert.ToInt32(txtCaja.Text);
            M.Convertir(Totalcentavos, out pesos, out centavo);
            lblC.Text = "C "+centavo.ToString();
            lblP.Text = "P "+ pesos.ToString();
        }

        private void cmdSalida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtCaja.Clear();
            lblC.Text = "C ";
            lblP.Text = "P ";
            txtCaja.Focus();
        }
    }
}
