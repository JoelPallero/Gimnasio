using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SaldosActualizados
    {
        public int Caja_ID { get; set; }
        public decimal Importe_Inicial { get; set; }
        public decimal Importe_Ingreso { get; set; }
        public decimal Importe_Egreso { get; set; }
        public decimal Total { get; set; }
    }
}
