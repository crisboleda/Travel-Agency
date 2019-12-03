using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_agency.AgencySucursal;
using Travel_agency.AgencyHotels;

namespace Travel_agency {
    public partial class ReservarHotel : Form {

        User superUser;
        List<Hotel> hoteles;
        List<Sucursal> sucursales;

        HotelManager _HotelManager;
        SucursalManager _SucursalManager;

        public ReservarHotel(User superUser) {
            this.superUser = superUser;
            InitializeComponent();
            Init();
        }

        public void Init() {
            _HotelManager = new HotelManager();
            _SucursalManager = new SucursalManager();

            ClearBoxes();
            GetHoteles();
            GetSucursales();
        }

        private void GetHoteles() {

            listViewHoteles.Items.Clear();
            hoteles = _HotelManager.GetHoteles("Activo");

            foreach (Hotel hotel in hoteles) {

                ListViewItem item = listViewHoteles.Items.Add(hotel.GetIDHotel().ToString());

                item.SubItems.Add(hotel.GetName());
                item.SubItems.Add(hotel.GetAddress());
                item.SubItems.Add(hotel.GetCity());
                item.SubItems.Add(hotel.GetCellphone().ToString());
                item.SubItems.Add(hotel.GetPlazasDisponibles().ToString());
            }
        }

        private void Click_Item_Hotel(object sender, MouseEventArgs e) {

            for (int i = 0; i < listViewHoteles.Items.Count; i++) {

                var rectangle = listViewHoteles.GetItemRect(i);

                if (rectangle.Contains(e.Location)) {

                    textBoxIDHotel.Text = hoteles[i].GetIDHotel().ToString();
                    textBoxNameHotel.Text = hoteles[i].GetName();
                    textBoxCityHotel.Text = hoteles[i].GetCity();
                    textBoxAddressHotel.Text = hoteles[i].GetAddress();
                    textBoxCellphoneHotel.Text = hoteles[i].GetCellphone().ToString();
                    textBoxRooms.Text = hoteles[i].GetPlazasDisponibles().ToString();

                }
            }
        }

        private void GetSucursales() {

            listViewSucursales.Items.Clear();
            sucursales = _SucursalManager.GetSucusales("Activo");

            foreach (Sucursal sucursal in sucursales) {

                ListViewItem item = listViewSucursales.Items.Add(sucursal.GetIDSucursal().ToString());

                item.SubItems.Add(sucursal.GetAddress());
                item.SubItems.Add(sucursal.GetCellphone());
            }
        }

        private void Click_Item_Sucursales(object sender, MouseEventArgs e) {

            for (int i = 0; i < listViewSucursales.Items.Count; i++) {

                var rectangle = listViewSucursales.GetItemRect(i);

                if (rectangle.Contains(e.Location)) {

                    textBoxIDSucursal.Text = sucursales[i].GetIDSucursal().ToString();
                    textBoxAddressSucursal.Text = sucursales[i].GetAddress();
                    textBoxCellphoneSucursal.Text = sucursales[i].GetCellphone();

                }
            }
        }

        private void ClearBoxes() {
            foreach (Control ctx in Controls) {
                if (ctx is TextBox) {
                    ctx.Text = "";
                }
            }
        }

        private void Click_Window(object sender, EventArgs e) {
            ClearBoxes();
        }

        private void button1_Click(object sender, EventArgs e) {
            
            if (CheckBoxes()) {



            }

        }


        public bool CheckBoxes() {

            if (textBoxIDHotel.Text != "" && textBoxIDSucursal.Text != "" && comboBoxPension.SelectedItem != null && Convert.ToInt16(cantidadHabitaciones.Value) != 0) {
                return true;
            }

            return false;
        }

    }
}
