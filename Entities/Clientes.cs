using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Clientes : Personas
    {
        public int Cliente_ID { get; set; }
        public DateTime Fecha_Alta { get; set; }
        public DateTime Fecha_Baja { get; set; }
        public string Estado { get; set; }
    }
}
