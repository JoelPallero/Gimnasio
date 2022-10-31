using AccesoDatos;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessClientes
    {

        private DataClientes _dataClientes;

        public BussinessClientes()
        {
            _dataClientes = new DataClientes();
        }

        public int AltaCliente(Clientes clientes)
        {
            return _dataClientes.AltaCliente(clientes);
        }
    }
}
