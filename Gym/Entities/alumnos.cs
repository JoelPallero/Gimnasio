using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Alumnos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Tipo_Documento_Id { get; set; }
        public string Num_Dni { get; set; }
        public string Telefono { get; set; }
        public string Alternativo { get; set; }
        public string Mail { get; set; }
        public DateTime Fecha_Inscripcion { get; set; }
        public string Observaciones { get; set; }
        public int Plan_Id { get; set; }
        public int Estado_Alumno_Id { get; set; }
        public int Estado_Facturacion_Id { get; set; }
        public int Login_Id { get; set; }
        public int Jornada_Id { get; set; }
    }
}