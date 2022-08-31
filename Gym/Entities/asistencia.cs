using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class asistencia
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int estado_id { get; set; }
        public int alumno_id { get; set; }
    }
}
