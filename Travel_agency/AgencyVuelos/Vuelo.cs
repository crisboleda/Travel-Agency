using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency.AgencyVuelos {

    class Vuelo {

        private int idVuelo;
        private string dateVuelo;
        private string timeVuelo;
        private string origen;
        private string destino;
        private int plazasTotales;
        private int plazasClaseTurista;

        public Vuelo(int idVuelo, string dateVuelo, string timeVuelo, string origen, string destino, int plazasTotales, int plazasClaseTurista) {
            this.idVuelo = idVuelo;
            this.dateVuelo = dateVuelo;
            this.timeVuelo = timeVuelo;
            this.origen = origen;
            this.destino = destino;
            this.plazasTotales = plazasTotales;
            this.plazasClaseTurista = plazasClaseTurista;
        }

        public int GetIDVuelo() {
            return idVuelo;
        }

        public string GetDateVuelo() {
            return dateVuelo;
        }

        public string GetTimeVuelo() {
            return timeVuelo;
        }

        public string GetOrigen() {
            return origen;
        }

        public string GetDestino() {
            return destino;
        }

        public int GetPlazasTotales() {
            return plazasTotales;
        }

        public int GetPlazasClaseTurista() {
            return plazasClaseTurista;
        }
    }

}
