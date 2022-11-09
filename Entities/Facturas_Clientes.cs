using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Facturas_Clientes
    {
        public int Factura_Cliente_ID { get; set; }
        public int Plan_Asignado_ID { get; set; }
        public int Persona_ID { get; set; }
        public decimal Importe { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public decimal Saldo { get; set; }
    }
}
