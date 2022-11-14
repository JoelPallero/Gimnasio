using AccesoDatos;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessCaja
    {
        private readonly DataCaja _dataCaja;
        public BussinessCaja()
        {
            _dataCaja = new DataCaja();
        }
        public DataSet ConsultarSaldos(Detalles_Cajas _detalles_Cajas)
        {
            return _dataCaja.ConsultarSaldos(_detalles_Cajas);
        }

        public int AbrirCaja(Cajas caja)
        {
            return _dataCaja.AbrirCaja(caja);
        }

        public Cajas ConsultarIDCajaAbierta(Cajas caja)
        {
            return _dataCaja.ConsultarIDCajaAbierta(caja);
        }

        public DataSet GetCajas(string buscar)
        {
            return _dataCaja.GetCajas(buscar);
        }
    }
}
