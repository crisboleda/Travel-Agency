using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency {

    public class User {

        // Definición de los atributos que tiene un Usuario en el sistema
        private int cedula;
        private string rol;
        private string name;
        private string lastname;
        private string address;
        private string cellphone;
        private string email;
        private string password;
           
        // Constructor para crear Usuarios, pasandole los atributos
        public User(int cedula, string rol, string name, string lastname, string address, string cellphone, string email, string password) {
            this.cedula = cedula;
            this.rol = rol;
            this.name = name;
            this.lastname = lastname;
            this.address = address;
            this.cellphone = cellphone;
            this.email = email;
            this.password = password;
        }

        // Setters y Getters 

        public void SetCedula(int cedula) {
            this.cedula = cedula;
        }

        public int GetCedula() {
            return cedula;
        }

        public void SetRol(string rol) {
            this.rol = rol;
        }

        public string GetRol() {
            return rol;
        }

        public void SetName(string name) {
            this.name = name;
        }

        public string GetName() {
            return name;
        }

        public void SetLastName(string lastname) {
            this.lastname = lastname;
        }

        public string GetLastName() {
            return lastname;
        }

        public void SetAddress(string address) {
            this.address = address;
        }

        public string GetAddress() {
            return address;
        }

        public void SetCellphone(string cellphone) {
            this.cellphone = cellphone;
        }

        public string GetCellphone() {
            return cellphone;
        }

        public void SetEmail(string email) {
            this.email = email;
        }

        public string GetEmail() {
            return email;
        }

        public void SetPassword(string password) {
            this.password = password;
        }

        public string GetPassword() {
            return password;
        }
    }

}
