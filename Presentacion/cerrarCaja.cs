using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class cerrarCaja : Form
    {
        CommonClass _commonClass = new CommonClass();
        public cerrarCaja()
        {
            InitializeComponent();
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            _commonClass.CajaAbierta = false;
            this.Close();
        }
    }
}
