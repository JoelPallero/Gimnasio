using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    //Esta entidad es para las cuotas que se generan cuando un alumno
    //se inscribe por ejemplo en una clase de x cosa en el gym.
    //se van a generar 6 cuotas automáticas si las clase duran 6 meses
    //y cada cuota va a tener un estado, a medida que entramos en el mes, cambia
    // de estado y si se vence tmb, y si no está cerca de la fecha de pago o vigente
    //va a tener otro estado.
    public class estado_cuota_alumno
    {
        public int id { get; set; }
        public string estado { get; set; }
    }
}
