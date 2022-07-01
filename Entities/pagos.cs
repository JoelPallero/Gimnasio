using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class pagos
    {
        public int id { get; set; }
        public decimal importe { get; set; }
        public DateTime fecha_emision { get; set; }
        public DateTime feha_vencimiento { get; set; }
        public DateTime fecha_pago { get; set; }
        public int concepto_id { get; set; }
        public int estado_cuota_id { get; set; }
        public int alumno_id { get; set; }
        public int empleado_id { get; set; }
    }
}
