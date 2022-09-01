using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class login_empleado
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int estado_login { get; set; }
    }
}
