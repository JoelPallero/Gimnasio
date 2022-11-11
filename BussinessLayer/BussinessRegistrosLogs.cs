using AccesoDatos;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessRegistrosLogs
    {
        private readonly DataRegistrosLogs _dataRegistrosLogs;
        public BussinessRegistrosLogs()
        {
            _dataRegistrosLogs = new DataRegistrosLogs();
        }

        public int RegistrarLogin(Registros_Logs _registrosLogs)
        {
            return _dataRegistrosLogs.RegistrarLogin(_registrosLogs);
        }

        public int RegistrarLogOut(Registros_Logs _registrosLogs)
        {
            return _dataRegistrosLogs.RegistrarLogOut(_registrosLogs);
        }

        public Registros_Logs GetLastLogID(Registros_Logs registros_Logs)
        {
            return _dataRegistrosLogs.GetLastLogID(registros_Logs);
        }
    }
}
