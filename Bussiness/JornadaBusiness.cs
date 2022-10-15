using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class JornadaBusiness
    {
        private readonly DataJornada _dataJornada;
        public JornadaBusiness()
        {
            _dataJornada = new DataJornada();
        }

        public jornada CreateJornadaAll(jornada _jornada)
        {
            if (_jornada.id == 0)
            {
                _dataJornada.CreatingJornadaUnica(_jornada);
            }
            else
            {

            }
            return _jornada;
        }

        public jornada CreateJornada(jornada _jornada)
        {
            if (_jornada.id == 0)
            {
                _dataJornada.CreatingJornada(_jornada);
            }
            else
            {

            }

            return _jornada;
        }
    }
}
