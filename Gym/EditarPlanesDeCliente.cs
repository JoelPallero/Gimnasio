using BussinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class EditarPlanesDeCliente : Form
    {
        #region Isntancias
        private readonly BussinessPlanesAsignados _bussinessPlanesAsignados;
        private readonly Planes_Asignados _planesAsignados;

        #endregion

        #region Variables

        string lim;
        string[] planes;
        char[] delimitador = { ' ', ':', ';', '-', '\\', ',' };

        #endregion
        public EditarPlanesDeCliente(string planes)
        {
            InitializeComponent();
            _bussinessPlanesAsignados = new BussinessPlanesAsignados();
            lim = planes;
            cargarPlanesParaEliminar();
        }

        private void cargarPlanesParaEliminar()
        {
            int marginTop = 10;
            if (!string.IsNullOrEmpty(lim))
            {
                planes = lim.Split(delimitador);
                foreach (var plan in planes)
                {
                    if (!string.IsNullOrEmpty(plan))
                    {
                        CheckBox chk = new CheckBox()
                        {
                            Name = plan,
                            Text = plan,
                            Checked = false,
                            Visible = true,
                            Enabled = true,
                            Location = new Point(30, marginTop)
                        };
                        Controls.Add(chk);
                        marginTop += 30;
                    }
                }
            }
        }

        private void btnEliminarPlanes_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CheckBox chk)
                {
                    CheckBox c;
                    c = chk;
                    if (c.Checked)
                    {
                        _planesAsignados.Estado = "I";
                        string nombrePlan = c.Name;
                        _bussinessPlanesAsignados.EliminarAsignacion(_planesAsignados, nombrePlan);
                    }
                }
            }
        }
    }
}
