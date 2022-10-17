using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Caja : Form
    {
        commonClass _commonClass = new commonClass();
        public Caja()
        {
            InitializeComponent();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            _commonClass.CajaAbierta = true;
            this.Close();
        }
    }
}
