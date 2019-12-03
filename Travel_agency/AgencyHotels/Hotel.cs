using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency.AgencyHotels {

    class Hotel {

        private int idHotel;
        private string name;
        private string address;
        private string city;
        private int cellphone;
        private int habitacionesDisponibles;

        public Hotel(int idHotel, string name, string address, string city, int cellphone, int plazasDisponibles) {
            this.idHotel = idHotel;
            this.name = name;
            this.address = address;
            this.city = city;
            this.cellphone = cellphone;
            habitacionesDisponibles = plazasDisponibles;
        }


        public int GetIDHotel() {
            return idHotel;
        }

        public string GetName() {
            return name;
        }

        public string GetAddress() {
            return address;
        }

        public string GetCity() {
            return city;
        }

        public int GetCellphone() {
            return cellphone;
        }

        public int GetPlazasDisponibles() {
            return habitacionesDisponibles;
        }
    }

}
