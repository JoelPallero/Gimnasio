using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class alumnos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int tipo_documento_id { get; set; }
        public string num_dni { get; set; }
        public string telefono { get; set; }
        public string alternativo { get; set; }
        public string mail { get; set; }
        public DateTime fecha_inscripcion { get; set; }
        public string observaciones { get; set; }
        public int plan_id { get; set; }
        public int estado_alumno_id { get; set; }
        public int estado_facturacion_id { get; set; }
        public int login_id { get; set; }
        public int jornada_id { get; set; }
    }
}