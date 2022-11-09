using System.Windows.Forms;

namespace Gym
{
    public partial class Configuracion : Form
    {
        public Configuracion(int idPersonaLogin)
        {
            InitializeComponent();
            personaLogueada = idPersonaLogin;
        }

        #region Variables
        private int personaLogueada;

        #endregion
    }
}
