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

namespace Travel_agency {
    public partial class Vuelos : Form {

        VueloManager _VueloManager;
        List<Vuelo> vuelos;
        User super_user;

        public Vuelos(User super_user) {
            this.super_user = super_user;
            InitializeComponent();
            Init();
        }

        private void Init() {
            _VueloManager = new VueloManager();

            btnDeleteVuelo.Enabled = false;
            btnUpdateVuelo.Enabled = false;

            GetVuelos("Activo");
        }

        private void GetVuelos(string estado) {
            listViewVuelos.Items.Clear();
            vuelos = _VueloManager.GetVuelos(estado);

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

        private void btnCreateVuelo_Click(object sender, EventArgs e) {

            if (CheckBoxNotEmpty()) {

                try {
                    string date = GetDate();
                    string format = GetTypeTime();

                    _VueloManager.CreateVuelo(
                        date,
                        textBoxTime.Text.ToString() + format,
                        textBoxOrigen.Text.ToString(),
                        textBoxDestino.Text.ToString(),
                        Convert.ToInt32(plazasTotales.Value.ToString()),
                        Convert.ToInt32(plazasTurista.Value.ToString()),
                        super_user.GetCedula()
                    );
                    clearBoxes();
                    GetVuelos("Activo");
                }
                catch {
                    MessageBox.Show("Error");
                }
            }
        }

        private bool CheckBoxNotEmpty() {
            if (dateTimePickerDate.Value != null && textBoxTime.Text != "" && 
                textBoxOrigen.Text != "" && textBoxDestino.Text != "" && plazasTotales.Value.ToString() != "" && plazasTurista.Value.ToString() != "") {
                return true;
            }
            return false;
        }

        private void clearBoxes() {

            foreach (Control ctr in Controls) {
                if (ctr is TextBox) {
                    ctr.Text = "";
                };
            }

        }

        private void Mouse_Click(object sender, MouseEventArgs e) {

            btnCreateVuelo.Enabled = false;

            for (int i = 0; i < listViewVuelos.Items.Count; i++) {

                var rectangle = listViewVuelos.GetItemRect(i);

                if (rectangle.Contains(e.Location)) {
                    textBoxID.Text = vuelos[i].GetIDVuelo().ToString();

                    dateTimePickerDate.Value = DateTime.Parse(vuelos[i].GetDateVuelo() + " 0:00:00");
                    string[] times = (vuelos[i].GetTimeVuelo()).Split(' ');

                    textBoxTime.Text = times[0];
                    textBoxOrigen.Text = vuelos[i].GetOrigen();
                    textBoxDestino.Text = vuelos[i].GetDestino();
                    plazasTurista.Value = vuelos[i].GetPlazasClaseTurista();
                    plazasTotales.Value = vuelos[i].GetPlazasTotales();

                    btnUpdateVuelo.Enabled = true;
                    btnDeleteVuelo.Enabled = true;
                }
            }
        }

        private void listViewVuelos_SelectedIndexChanged(object sender, EventArgs e) {
            DisableBtnUpdateDelete();
        }

        private void Click_Window(object sender, EventArgs e) {
            DisableBtnUpdateDelete();
        }

        private void btnUpdateVuelo_Click(object sender, EventArgs e) {


            if (CheckBoxNotEmpty()) {
                try {

                    string date = GetDate();
                    string format = GetTypeTime();

                    _VueloManager.UpdateVuelo(
                        Convert.ToInt32(textBoxID.Text.ToString()),
                        date,
                        textBoxTime.Text.ToString() + format,
                        textBoxOrigen.Text.ToString(),
                        textBoxDestino.Text.ToString(),
                        Convert.ToInt32(plazasTotales.Value),
                        Convert.ToInt32(plazasTurista.Value));


                    clearBoxes();
                    btnCreateVuelo.Enabled = true;
                }
                catch {
                    MessageBox.Show("Error");
                }
            }

            DisableBtnUpdateDelete();
            GetVuelos("Activo");
        }

        private void btnDeleteVuelo_Click(object sender, EventArgs e) {

            if (CheckBoxNotEmpty()) {
                _VueloManager.DeleteVuelo(Convert.ToInt32(textBoxID.Text));

                clearBoxes();
                btnCreateVuelo.Enabled = true;
            }

            DisableBtnUpdateDelete();
            GetVuelos("Activo");

            radioButton1.Checked = true;

        }


        private string GetTypeTime() {
            string format = " AM";

            if (listBoxFormatTime.SelectedIndex == 1) {
                format = " PM";
            }

            return format;
        }

        private string GetDate() {
            return ((dateTimePickerDate.Value.ToString()).Split(' '))[0];
        }

        private void DisableBtnUpdateDelete() {
            btnCreateVuelo.Enabled = true;
            btnUpdateVuelo.Enabled = false;
            btnDeleteVuelo.Enabled = false;
            clearBoxes();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            GetVuelos("Inactivo");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            GetVuelos("Activo");
        }
    }
}
