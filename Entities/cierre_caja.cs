using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class cierre_caja
    {
        public int id { get; set; }
        public int caja_cerrada { get; set; }
        public int caja_abierta_id { get; set; }
        public decimal monto_cierre_efectivo { get; set; }
        public decimal monto_cierre_caja { get; set; }
        public DateTime fecha_cierre { get; set; }
        public int login_id { get; set; }
    }
}
