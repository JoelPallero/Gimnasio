using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Registros_Logs
    {
        public int Registro_Log_ID { get; set; }
        public int Empleado_ID { get; set; }
        public DateTime Fecha_LogIn { get; set; }
        public DateTime Fecha_LogOut { get; set; }
    }
}
