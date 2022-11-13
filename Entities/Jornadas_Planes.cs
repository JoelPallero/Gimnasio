using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Jornadas_Planes
    {
        public int Jornada_Plan_ID { get; set; }
        public int Plan_ID { get; set; }
        public string Dia { get; set; }
        public DateTime Desde_Hora { get; set; }
        public DateTime Hasta_Hora { get; set; }
        public string Estado { get; set; }
    }
}
