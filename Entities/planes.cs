using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Planes
    {
        public int Plan_ID { get; set; }
        public int Persona_ID { get; set; }
        public int Empleado_ID { get; set; }
        public string Nombre { get; set; }
        public decimal Importe_Plan { get; set; }
        public int Duracion { get; set; }
        public int Cupo_Total { get; set; }
        public int Cupo_Restante { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_Alta_Plan { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
    }
}