using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency.AgencySucursal {

    class Sucursal {

        private int id_sucursal;
        private string address;
        private string cellphone;

        public Sucursal(int id_sucursal, string address, string cellphone) {
            this.id_sucursal = id_sucursal;
            this.address = address;
            this.cellphone = cellphone;
        }


        public int GetIDSucursal() {
            return id_sucursal;
        }

        public string GetAddress() {
            return address;
        }

        public string GetCellphone() {
            return cellphone;
        }

    }

}
