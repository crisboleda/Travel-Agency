using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_agency.AgencyUser;
using Travel_agency.AgencyVuelos;

namespace Travel_agency {

    public partial class PanelAdmin : Form {

        User super_user;
        Form1 parent;

        public PanelAdmin(User super_user, Form1 parent) {
            this.super_user = super_user;
            this.parent = parent;

            InitializeComponent();
            ShowView(new Perfil(super_user, menuStrip1));
        }

        // Controlamos el click de cada item del menú superior
        private void Click_Item_Menu(object sender, ToolStripItemClickedEventArgs e) {

            closeForms();
            resetMenuItems();
            e.ClickedItem.Enabled = false;

            if (e.ClickedItem.Name == "MenuItemPerfil") {
                ShowView(new Perfil(super_user, menuStrip1));

            }
            else if (e.ClickedItem.Name == "MenuItemSucursales") {
                ShowView(new Sucursales());

            }
            else if (e.ClickedItem.Name == "MenuItemHoteles") {
                ShowView(new ViewHotelAdmin(super_user));

            }
            else if (e.ClickedItem.Name == "MenuItemVuelos") {
                ShowView(new Vuelos(super_user));

            }
            else if (e.ClickedItem.Name == "MenuItemReservasVuelos") {
                ShowView(new ReservasVuelosAdmin());

            }
            else if (e.ClickedItem.Name == "MenuItemReservasHoteles") {
                ShowView(new ReservasHotelesAdmin());

            }
            else if (e.ClickedItem.Name == "MenuItemCerrar") {
                new Form1().Show();
                this.Hide();
            }
        }

        // Mostramos una vista que le pasamos como parametro (Dentro del padre "this")
        private void ShowView(Form view) {
            view.MdiParent = this;
            view.Show();
        }

        // Cerramos todos los forms dentro de la ventana padre
        private void closeForms() {
            foreach (Form window in MdiChildren) {
                window.Close();
            }
        }

        // Restablecemos todos los items a Enable (Que pueden ser clickeados)
        private void resetMenuItems() {
            foreach (ToolStripMenuItem item in menuStrip1.Items) {
                item.Enabled = true;
            }
        }

        private void Close_Forms(object sender, FormClosingEventArgs e) {
            parent.Close();
        }

    }
}
