using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Jornadas_Empleados
    {
        public int Jornada_Empleado_ID { get; set; }
        public int Empleado_ID { get; set; }
        public string Dia { get; set; }
        public string Desde_Hora { get; set; }
        public string Hasta_Hora { get; set; }
    }
}
