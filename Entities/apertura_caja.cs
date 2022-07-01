using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class apertura_caja
    {
        public int id { get; set; }
        public int caja_abierta { get; set; }
        public decimal monto_apertura_efectivo { get; set; }
        public DateTime fecha_apertura { get; set; }
        public int login_id { get; set; }
    }
}
