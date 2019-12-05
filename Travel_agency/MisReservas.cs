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
using Travel_agency.AgencyVuelos;

namespace Travel_agency {
    public partial class MisReservas : Form {

        HotelManager _HotelManager;
        VueloManager _VueloManager;

        User superUser;
        List<ReservaHotel> reservasHoteles = new List<ReservaHotel>();
        List<ReservaVuelo> reservasVuelos = new List<ReservaVuelo>();

        public MisReservas(User superUser) {
            this.superUser = superUser;

            InitializeComponent();
            Init();
        }

        public void Init() {
            _HotelManager = new HotelManager();
            _VueloManager = new VueloManager();

            GetReservasHoteles();
            GetReservasVuelos();

            SetDataReservaHotelesListView();
            SetDataReservaVuelosListView();
        }

        public void GetReservasHoteles() {
            List<ReservaHotel> allReservas = _HotelManager.GetReservasHoteles();

            foreach (ReservaHotel reserva in allReservas) {
                if (Convert.ToInt32(reserva.GetCodTurista()) == superUser.GetCedula()) {
                    reservasHoteles.Add(reserva);
                }
            }
        }

        public void GetReservasVuelos() {

            List<ReservaVuelo> allReservas = _VueloManager.GetReservasVuelo();

            foreach (ReservaVuelo reserva in allReservas) {
                if (Convert.ToInt32(reserva.GetCodTurista()) == superUser.GetCedula()) {
                    reservasVuelos.Add(reserva);
                }
            }
        }

        public void SetDataReservaHotelesListView() {

            listViewReservaHoteles.Items.Clear();

            foreach (ReservaHotel reserva in reservasHoteles) {

                int CodHotel = reserva.GetCodHotel();
                string pension = reserva.GetPension();
                string fechaLlegada = reserva.GetFechaLlegada();
                string fechaSalida = reserva.GetFechaSalida();

                Hotel hotel = _HotelManager.GetHotelReserva(CodHotel);

                ListViewItem item = listViewReservaHoteles.Items.Add(reserva.GetIDReserva().ToString());

                item.SubItems.Add(hotel.GetName());
                item.SubItems.Add(hotel.GetAddress());
                item.SubItems.Add(hotel.GetCity());
                item.SubItems.Add(hotel.GetCellphone().ToString());
                item.SubItems.Add(fechaLlegada);
                item.SubItems.Add(fechaSalida);
                item.SubItems.Add(pension);
            }
        }

        public void SetDataReservaVuelosListView() {

            listViewReservaVuelos.Items.Clear();

            foreach (ReservaVuelo reserva in reservasVuelos) {

                int CodVuelo = reserva.GetCodVuelo();
                string claseVuelo = reserva.GetClaseVuelo();

                Vuelo vuelo = _VueloManager.GetVueloReservado(CodVuelo);

                ListViewItem item = listViewReservaVuelos.Items.Add(reserva.GetIDReservaVuelo().ToString());

                item.SubItems.Add(vuelo.GetDateVuelo());
                item.SubItems.Add(vuelo.GetTimeVuelo());
                item.SubItems.Add(vuelo.GetOrigen());
                item.SubItems.Add(vuelo.GetDestino());
                item.SubItems.Add(claseVuelo);

            }

        }

    }
}
