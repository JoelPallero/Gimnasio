using AccesoDatos;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessPersonas
    {
        private readonly DataPersonas _dataPersonas;
        public BussinessPersonas()
        {
            _dataPersonas = new DataPersonas();
        }

        public int AltaPersona(Personas personas)
        {
            return _dataPersonas.AltaPersona(personas);
        }

        public Personas Get_Last_Id_Persona(Personas personas)
        {
            return _dataPersonas.Get_Las_Id_Personas(personas);
        }
    }
}
