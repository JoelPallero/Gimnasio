using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Personas
    {
        public int Persona_ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Tipo_Documento_ID { get; set; }
        public string Nro_documento { get; set; }
        public int Tipo_Sexo_ID { get; set; }
        public string Nro_Telefono { get; set; }
        public string Nro_Alternativo { get; set; }
        public string Mail { get; set; }
        public string Observaciones { get; set; }
    }
}