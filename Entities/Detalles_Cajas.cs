using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Detalles_Cajas
    {
        public int Detalle_Caja_ID { get; set; }
        public int Caja_ID { get; set; }
        public int Empleado_ID { get; set; }
        public int Plan_Asignado_ID { get; set; }
        public decimal Importe_Ingreso { get; set; }
        public decimal Importe_Egreso { get; set; }
        public string Motivo { get; set; }
        public string Observaciones { get; set; }
    }
}