using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency.AgencyHotels
{
    class Hotels{

        private int id_hotel;
        private string name;
        private string address;
        private string city;
        private string cellphone;
        private int number_plazas_disponibles;

        public Hotels(int id_hotel, string address, string cellphone, string name, string city, int number_plazas_disponibles){
            this.id_hotel = id_hotel;
            this.address = address;
            this.cellphone = cellphone;
            this.name = name;
            this.city = city;
            this.number_plazas_disponibles = number_plazas_disponibles;

        }

        public int GetIDHote(){
            return id_hotel;
        }

        public string GetAddress(){
            return address;
        }

        public string GetCellphone(){
            return cellphone;
        }

        public string GetName()
        {
            return name;
        }

        public string GetCity()
        {
            return city;
        }

        public int GetNumber_plazas_disponibles()
        {
            return number_plazas_disponibles;
        }
    }
}
