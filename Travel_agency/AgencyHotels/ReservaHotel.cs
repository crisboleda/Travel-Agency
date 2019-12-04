using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency.AgencyHotels {

    class ReservaHotel {

        private int IdReserva;
        private int CodHotel;
        private string CodTurista;
        private int CodSucursal;
        private string pension;
        private string fechaLlegada;
        private string fechaSalida;

        public ReservaHotel(int IdReserva, int CodHotel, string CodTurista, int CodSucursal, string pension, string fechaLlegada, string fechaSalida 
            ) {

            this.IdReserva = IdReserva;
            this.CodHotel = CodHotel;
            this.CodTurista = CodTurista;
            this.CodSucursal = CodSucursal;
            this.pension = pension;
            this.fechaLlegada = fechaLlegada;
            this.fechaSalida = fechaSalida;

        }


        public int GetIDReserva() {
            return IdReserva;
        }

        public int GetCodHotel() {
            return CodHotel;
        }

        public string GetCodTurista() {
            return CodTurista;
        }

        public int GetCodSucursal() {
            return CodSucursal;
        }

        public string GetPension() {
            return pension;
        }

        public string GetFechaLlegada() {
            return fechaLlegada;
        }

        public string GetFechaSalida() {
            return fechaSalida;
        }


    }
}
