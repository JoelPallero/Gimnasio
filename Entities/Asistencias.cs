using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Asistencias
    {
        public int Asistencia_ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int Cliente_ID { get; set; }
        public int Empleado_ID { get; set; }
        public int Plan_Asignado_ID { get; set; }
    }
}
