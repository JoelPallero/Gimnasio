using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class MetodosGenerales
    {
        #region Instancias
        private readonly BussinessTipos_Documentos _bussinessTipos_Documentos = new BussinessTipos_Documentos();
        public DataSet DsTipos_Documentos = new DataSet();

        #endregion
        //Poner el arrastre del form
        //y todos los botones o eventos comunes en cada formulario
        //en caso de poder hacerlo xD



        /*tareas*/

        //Asignar el ID del usuario´con el login abierto para utilizarlo
        //como huella en los distintos registros.

        public bool CajaAbierta = true;


        // Traeremos los tipos de documento, entre otros datos comunes desde acá

        public void Bring_Tipos_Documentos()
        {
            DsTipos_Documentos = _bussinessTipos_Documentos.BringTipoDocumento();
        }


    }
}
