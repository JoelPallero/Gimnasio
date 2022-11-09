using System.Windows.Forms;

namespace Gym
{
    public partial class Pagos : Form
    {
        public Pagos(int idPersonaLogin)
        {
            InitializeComponent();
            personaLogueada = idPersonaLogin;
        }

        #region Variables

        private int personaLogueada;

        #endregion
    }
}
