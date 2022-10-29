using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Cuotas
    {
        public int Cuota_ID { get; set; }
        public int Plan_Asignado_ID { get; set; }
        public int Empleado_ID { get; set; }
        public int Detalle_Caja_ID { get; set; }
        public decimal Importe_Cuota { get; set; }
        public decimal Saldo { get; set; }
        public DateTime Vto_Cuota { get; set; }
    }
}
