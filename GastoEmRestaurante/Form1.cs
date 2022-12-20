using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastoEmRestaurante
{
    public partial class frmGastoRestaurante : Form
    {
        public frmGastoRestaurante()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotalConta.Text = (Convert.ToDouble(txtDespesa.Text) * 1.10).ToString("N");
        }
    }
}
