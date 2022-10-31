using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Empleados
    {
        public int Empleado_ID { get; set; }
        public int Persona_ID { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public int Tipo_Empleado_ID { get; set; }
        public int Estado_Empleado_ID { get; set; }
    }
}
