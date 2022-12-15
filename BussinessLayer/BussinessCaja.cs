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
        public SaldosActualizados ConsultarSaldos(SaldosActualizados saldos)
        {
            return _dataCaja.ConsultarSaldos(saldos);
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

        public int RegistrarCobro(Detalles_Cajas detalles_Cajas)
        {
            return _dataCaja.RegistrarCobro(detalles_Cajas);
        }

        public int RegistrarPago(Detalles_Cajas detalles_Cajas)
        {
            return _dataCaja.RegistrarPago(detalles_Cajas);
        }

        public DataSet GetDetalles(string buscar)
        {
            return _dataCaja.GetDetallesDiarios(buscar);
        }
    }
}
