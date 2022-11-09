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
    public partial class Asistencias : Form
    {
        public Asistencias(int idPersonaLog)
        {
            InitializeComponent();
            personaLogueada = idPersonaLog;
        }

        #region Variables 
        private int personaLogueada;

        #endregion

    }
}
