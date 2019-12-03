using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency.AgencyVuelos {

    class ReservaVuelo {

        private int idReservaVuelo;
        private int codVuelo;
        private int codTurista;
        private int codSucursal;
        private string claseVuelo;
        private int asientos;

        public ReservaVuelo(int idReservaVuelo, int codVuelo, int codTurista, int codSucursal, string claseVuelo, int asientos) {
            this.idReservaVuelo = idReservaVuelo;
            this.codVuelo = codVuelo;
            this.codTurista = codTurista;
            this.codSucursal = codSucursal;
            this.claseVuelo = claseVuelo;
            this.asientos = asientos;
        }


        public int GetIDReservaVuelo() {
            return idReservaVuelo;
        }

        public int GetCodVuelo() {
            return codVuelo;
        }

        public int GetCodTurista() {
            return codTurista;
        }

        public int GetCodSucursal() {
            return codSucursal;
        }

        public string GetClaseVuelo() {
            return claseVuelo;
        }

        public int GetAsientos() {
            return asientos;
        }

    }

}
