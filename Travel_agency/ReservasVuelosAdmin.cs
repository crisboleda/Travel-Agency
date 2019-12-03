using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_agency.AgencyVuelos;
using Travel_agency.AgencyUser;
using Travel_agency.AgencySucursal;

namespace Travel_agency {
    public partial class ReservasVuelosAdmin : Form {

        VueloManager _VueloManager;
        UserManager _UserManager;
        SucursalManager _SucursalManager;

        List<ReservaVuelo> reservas;

        public ReservasVuelosAdmin() {
            InitializeComponent();
            Init();
        }

        public void Init() {
            _VueloManager = new VueloManager();
            _UserManager = new UserManager();
            _SucursalManager = new SucursalManager();

            GetReservasVuelos();
        }

        private void GetReservasVuelos() {

            listViewReservasVuelos.Items.Clear();
            reservas = _VueloManager.GetReservasVuelo();

            foreach (ReservaVuelo reserva in reservas) {

                ListViewItem item = listViewReservasVuelos.Items.Add(reserva.GetIDReservaVuelo().ToString());

                item.SubItems.Add(reserva.GetCodVuelo().ToString());
                item.SubItems.Add(reserva.GetCodTurista().ToString());
                item.SubItems.Add(reserva.GetCodSucursal().ToString());
                item.SubItems.Add(reserva.GetClaseVuelo());
                item.SubItems.Add(reserva.GetAsientos().ToString());

            }

        }

        private void Click_Item(object sender, MouseEventArgs e) {

            for (int i = 0; i < listViewReservasVuelos.Items.Count; i++) {

                var rectangle = listViewReservasVuelos.GetItemRect(i);

                if (rectangle.Contains(e.Location)) {

                    int CodVuelo = reservas[i].GetCodVuelo();
                    int CodTurista = reservas[i].GetCodTurista();
                    int CodSucursal = reservas[i].GetCodSucursal();

                    Vuelo vuelo = _VueloManager.GetVueloReservado(CodVuelo);
                    User user = _UserManager.GetUserReservaVuelo(CodTurista);
                    Sucursal sucursal = _SucursalManager.GetSurcusalReservaVuelo(CodSucursal);

                    ShowDataVuelo(vuelo);
                    ShowDataTurista(user);
                    ShowDataSucursal(sucursal);
                }
            }
        }

        private void ShowDataVuelo(Vuelo vuelo) {

            textBoxDateVuelo.Text = vuelo.GetDateVuelo();
            textBoxTimeVuelo.Text = vuelo.GetTimeVuelo();
            textBoxOrigenVuelo.Text = vuelo.GetOrigen();
            textBoxDestinoVuelo.Text = vuelo.GetDestino();

        }

        private void ShowDataTurista(User user) {

            textBoxNameTurista.Text = user.GetName();
            textBoxLastNameTurista.Text = user.GetLastName();
            textBoxAddressTurista.Text = user.GetAddress();
            textBoxCellphoneTurista.Text = user.GetCellphone();
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
