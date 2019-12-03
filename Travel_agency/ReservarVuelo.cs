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
using Travel_agency.AgencySucursal;

namespace Travel_agency {
    public partial class ReservarVuelo : Form {

        User super_user;
        VueloManager _VueloManager;
        SucursalManager _SucursalManager;
        List<Vuelo> vuelos;
        List<Sucursal> sucursales;


        public ReservarVuelo(User super_user) {
            this.super_user = super_user;
            InitializeComponent();
            Init();
        }

        public void Init() {
            _VueloManager = new VueloManager();
            _SucursalManager = new SucursalManager();

            GetVuelos();
            GetSucursales();
        }

        // Traemos todas las sucursales de la base de datos y la establecemos en el listview
        public void GetVuelos() {

            listViewVuelos.Items.Clear();
            vuelos = _VueloManager.GetVuelos();

            foreach (Vuelo vuelo in vuelos) {

                ListViewItem item = listViewVuelos.Items.Add(vuelo.GetIDVuelo().ToString());

                item.SubItems.Add(vuelo.GetDateVuelo());
                item.SubItems.Add(vuelo.GetTimeVuelo());
                item.SubItems.Add(vuelo.GetOrigen());
                item.SubItems.Add(vuelo.GetDestino());
                item.SubItems.Add(vuelo.GetPlazasClaseTurista().ToString());
                item.SubItems.Add(vuelo.GetPlazasTotales().ToString());
            }
        }

        // Controlamos el click de cada item del listView y mostramos los datos en los TextBox
        private void Mouse_Click(object sender, MouseEventArgs e) {

            for (int i = 0; i < listViewVuelos.Items.Count; i++) {

                var rectangle = listViewVuelos.GetItemRect(i);

                if (rectangle.Contains(e.Location)) {
                    textBoxID.Text = vuelos[i].GetIDVuelo().ToString();
                    dateTimePickerDate.Value = DateTime.Parse(vuelos[i].GetDateVuelo());
                    textBoxTime.Text = vuelos[i].GetTimeVuelo();
                    textBoxOrigen.Text = vuelos[i].GetOrigen();
                    textBoxDestino.Text = vuelos[i].GetDestino();
                }
            }
        }

        // Traemos todas las sucursales de la base de datos y la establecemos en el listview
        private void GetSucursales() {

            listViewSucursales.Items.Clear();
            sucursales = _SucursalManager.GetSucursales();

            foreach (Sucursal sucursal in sucursales) {

                // Creamos una fila y le agregamos un identificador
                ListViewItem item = listViewSucursales.Items.Add(sucursal.GetIDSucursal().ToString());

                // Apartir de la fila creada creamos las columnas de la fila
                item.SubItems.Add(sucursal.GetAddress());
                item.SubItems.Add(sucursal.GetCellphone());
            }
        }

        // Controlamos el click de cada item del listView y mostramos los datos en los TextBox
        private void Mouse_Click_Item_Sucursal(object sender, MouseEventArgs e) {

            for (int i = 0; i < listViewSucursales.Items.Count; i++) {

                var rectangle = listViewSucursales.GetItemRect(i);
                if (rectangle.Contains(e.Location)) {
                    textBox1.Text = sucursales[i].GetIDSucursal().ToString();
                    textBoxAddres.Text = sucursales[i].GetAddress();
                    textBoxCellphone.Text = sucursales[i].GetCellphone();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            string clase = "Turista";

            if (textBoxID.Text != "" && textBox1.Text != "" && classVuelo.Text != "") {

                if (classVuelo.SelectedIndex == 1) {
                    clase = "Primera";
                }

                int codVuelo = Convert.ToInt32(textBoxID.Text);
                int codTurista = super_user.GetCedula();
                int codSucursal = Convert.ToInt32(textBox1.Text);

                _VueloManager.GenerateReserva(codVuelo, codTurista, codSucursal, clase);
                MessageBox.Show("La reserva del vuelo se realizó con ¡Exito!");
                clearBoxes();

            }else {
                MessageBox.Show("Asegurate seleccionar y estables campos");
            }
        }

        private void clearBoxes() {
            foreach (Control ctr in Controls) {
                if (ctr is TextBox || ctr is ComboBox) {
                    ctr.Text = "";
                }
            }
        }
    }
}
