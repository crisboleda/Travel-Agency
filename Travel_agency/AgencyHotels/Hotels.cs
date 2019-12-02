using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency.AgencyHotels
{
    class Hotels{

        private int id_hotel;
        private string address;
        private string cellphone;

        public Hotels(int id_hotel, string address, string cellphone){
            this.id_hotel = id_hotel;
            this.address = address;
            this.cellphone = cellphone;
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
    }
}
