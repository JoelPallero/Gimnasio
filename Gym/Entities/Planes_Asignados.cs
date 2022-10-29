using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Planes_Asignados
    {
        public int Plan_Asignado_ID { get; set; }
        public int Plan_ID { get; set; }
        public int Cliente_ID { get; set; }
        public int Empleado_ID { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
    }
}
