using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Cajas
    {
        public int Caja_ID { get; set; }
        public int Empleado_ID_Apertura { get; set; }
        public DateTime Fecha_Apertura { get; set; }
        public DateTime Hora_Apertura { get; set; }
        public decimal Importe_Apertura { get; set; }
        public bool Caja_Abierta { get; set; }
        public int Empleado_ID_Cierre { get; set; }
        public DateTime Fecha_Cierre { get; set; }
        public DateTime Hora_Cierre { get; set; }
        public decimal Importe_Cierre { get; set; }
        public decimal Importe_Cierre_Caja { get; set; }
    }
}