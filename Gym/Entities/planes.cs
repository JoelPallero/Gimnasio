using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class planes
    {
        public int id { get; set; }
        public string nombre_plan { get; set; }
        public decimal importe { get; set; }
        public int estado_plan_id { get; set; }
        public int login_id { get; set; }
        public int jornada_id { get; set; }
    }
}
