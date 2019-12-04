using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_agency.AgencyHotels;
using Travel_agency.AgencyUser;
using Travel_agency.AgencySucursal;

namespace Travel_agency {
    public partial class ReservasHotelesAdmin : Form {

        HotelManager _HotelManager;
        UserManager _UserManager;
        SucursalManager _SucursalManager;

        List<ReservaHotel> reservas;

        public ReservasHotelesAdmin() {
            InitializeComponent();
            Init();
        }

        public void Init() {
            _HotelManager = new HotelManager();
            _UserManager = new UserManager();
            _SucursalManager = new SucursalManager();

            GetReservas();
        }

        public void GetReservas() {

            listViewReservas.Items.Clear();
            reservas = _HotelManager.GetReservasHoteles();

            foreach (ReservaHotel reserva in reservas) {

                ListViewItem item = listViewReservas.Items.Add(reserva.GetIDReserva().ToString());

                item.SubItems.Add(reserva.GetCodHotel().ToString());
                item.SubItems.Add(reserva.GetCodTurista());
                item.SubItems.Add(reserva.GetCodSucursal().ToString());
                item.SubItems.Add(reserva.GetPension());
                item.SubItems.Add(reserva.GetFechaLlegada());
                item.SubItems.Add(reserva.GetFechaSalida());

            }

        }

        private void Click_Item_Reserva(object sender, MouseEventArgs e) {

            for (int i = 0; i < listViewReservas.Items.Count; i++) {

                var rectangle = listViewReservas.GetItemRect(i);

                if (rectangle.Contains(e.Location)) {

                    Hotel foundHotel = _HotelManager.GetHotelReserva(reservas[i].GetCodHotel());
                    User foundUser = _UserManager.GetUserReservaVuelo(int.Parse(reservas[i].GetCodTurista()));
                    Sucursal foundSucursal = _SucursalManager.GetSurcusalReservaVuelo(reservas[i].GetCodSucursal());

                    ShowDataHotel(foundHotel);
                    ShowDataTurista(foundUser);
                    ShowDataSucursal(foundSucursal);
                }
            }
        }


        private void ShowDataHotel(Hotel hotel) {

            textBoxNameHotel.Text = hotel.GetName();
            textBoxCityHotel.Text = hotel.GetCity();
            textBoxAddressHotel.Text = hotel.GetAddress();
            textBoxCellphoneHotel.Text = hotel.GetCellphone().ToString();

        }


        private void ShowDataTurista(User user) {

            textBoxNameTurista.Text = user.GetName();
            textBoxLastNameTurista.Text = user.GetLastName();
            textBoxAddressTurista.Text = user.GetAddress();
            textBoxCellphoneTurista.Text = user.GetAddress();
            textBoxEmailTurista.Text = user.GetEmail();

        }

        private void ShowDataSucursal(Sucursal sucursal) {

            textBoxAddressSucursal.Text = sucursal.GetAddress();
            textBoxCellphoneSucursal.Text = sucursal.GetCellphone();

        }

        private void Click_Window(object sender, EventArgs e) {

            foreach (Control ctx in Controls) {
                if (ctx is TextBox) {
                    ctx.Text = "";
                }
            }

        }
    }
}
