using AccesoDatos;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataSet GetClientes(string buscar)
        {
            return _dataClientes.GetClientes(buscar);
        }

        public Clientes GetCliente(Clientes clientes)
        {
            return _dataClientes.GetCliente(clientes);
        }

        public int BajaCliente(Clientes clientes)
        {
            return _dataClientes.BajaCliente(clientes);
        }

        public DataSet BuscarClienteAsistencia(string buscar)
        {
            return _dataClientes.BuscarClienteAsistencia(buscar);
        }

        public DateTime VerClaseQueToca(DateTime fechaAhora)
        {
            return _dataClientes.VerClaseQueToca(fechaAhora);
        }

        public int EditarCliente(Clientes clientes)
        {
            return _dataClientes.EditarCliente(clientes);
        }

        //public DataTable BuscarCuotasCliente(int idCliente)
        //{
        //    return _dataClientes.BuscarCuotasCliente(idCliente);
        //}
    }
}
