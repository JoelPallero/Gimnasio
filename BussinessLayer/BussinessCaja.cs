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
        public SaldosActualizados ConsultarSaldos(Detalles_Cajas _detalles_Cajas, SaldosActualizados saldos)
        {
            return _dataCaja.ConsultarSaldos(_detalles_Cajas, saldos);
        }

        public int AbrirCaja(Cajas caja)
        {
            return _dataCaja.AbrirCaja(caja);
        }

        public Cajas ConsultarIDCajaAbierta(Cajas caja)
        {
            return _dataCaja.ConsultarIDCajaAbierta(caja);
        }

        public DataSet GetDetallesCajas(string buscar)
        {
            return _dataCaja.GetDetallesCajas(buscar);
        }

        public bool VerificarCajaAbierta(DateTime fecha)
        {
            bool cajaAbierta = _dataCaja.CajaAbierta(fecha);
            return cajaAbierta;
        }

        public Cajas GetLastCajaID(Cajas caja)
        {
            return _dataCaja.GetLastCajaID(caja);
        }

        public int CerrarCaja(Cajas caja)
        {
            return _dataCaja.CerrarCaja(caja);
        }
    }
}
