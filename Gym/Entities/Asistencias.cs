using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Asistencias
    {
        public int Asistencia_ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int Cliente_ID { get; set; }
        public int Empleado_ID { get; set; }
    }
}
