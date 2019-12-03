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

namespace Travel_agency {
    public partial class ViewHotelAdmin : Form {

        User super_user;
        List<Hotel> hoteles;
        HotelManager _HotelManager;

        public ViewHotelAdmin(User super_user) {
            this.super_user = super_user;
            InitializeComponent();
            Init();
        }


        public void Init() {
            _HotelManager = new HotelManager();
            DisableBtnUpdateDelete();
            GetHotels("Activo");
        }

        public void GetHotels(string estado) {
            listViewHotels.Items.Clear();

            hoteles = _HotelManager.GetHoteles(estado);

            foreach (Hotel hotel in hoteles) {
                ListViewItem item = listViewHotels.Items.Add(hotel.GetIDHotel().ToString());

                item.SubItems.Add(hotel.GetName());
                item.SubItems.Add(hotel.GetAddress());
                item.SubItems.Add(hotel.GetCity());
                item.SubItems.Add(hotel.GetCellphone().ToString());
                item.SubItems.Add(hotel.GetPlazasDisponibles().ToString());
            }
        }

        private void btnCreateHotel_Click(object sender, EventArgs e) {

            if (CheckBoxes()) {

                _HotelManager.CreateHotel(
                    textBoxName.Text.ToString(),
                    textBoxName.Text.ToString(),
                    textBoxCity.Text.ToString(),
                    Convert.ToInt32(textBoxCellphone.Text.ToString()),
                    Convert.ToInt32(boxHabitaciones.Value.ToString()),
                    super_user.GetCedula()
                );

                ClearBoxes();
                GetHotels("Activo");
            }
        }

        private void Mouse_Click_Item(object sender, MouseEventArgs e) {

            EnableBtnUpdateDelete();

            for (int i = 0; i < listViewHotels.Items.Count; i++) {

                var rectangle = listViewHotels.GetItemRect(i);
                        
                if (rectangle.Contains(e.Location)) {

                    textBoxID.Text = hoteles[i].GetIDHotel().ToString();
                    textBoxName.Text = hoteles[i].GetName();
                    textBoxAddress.Text = hoteles[i].GetAddress();
                    textBoxCity.Text = hoteles[i].GetCity();
                    textBoxCellphone.Text = hoteles[i].GetCellphone().ToString();
                    boxHabitaciones.Value = hoteles[i].GetPlazasDisponibles();
                }
            }

        }

        private void btnUpdateHotel_Click(object sender, EventArgs e) {

            if (CheckBoxes()) {
                _HotelManager.UpdateHotel(
                    Convert.ToInt32(textBoxID.Text),
                    textBoxName.Text,
                    textBoxAddress.Text,
                    textBoxCity.Text,
                    Convert.ToInt32(textBoxCellphone.Text),
                    Convert.ToInt32(boxHabitaciones.Value)
                );

                ClearBoxes();
                ResetAll();
                GetHotels("Activo");
            }
        }


        private void btnDeleteHotel_Click(object sender, EventArgs e) {
            if (CheckBoxes()) {
                _HotelManager.DeleteHotel(Convert.ToInt32(textBoxID.Text));

                ClearBoxes();
                ResetAll();
                GetHotels("Activo");
            }

            radioButton1.Checked = true;
        }


        public bool CheckBoxes() {
            if (textBoxName.Text.ToString() != "" && textBoxAddress.Text.ToString() != "" && textBoxCity.Text.ToString() != ""
                && textBoxCellphone.Text.ToString() != "" && boxHabitaciones.Value.ToString() != "" && boxHabitaciones.Value != 0) {

                return true;
            }

            return false;
        }

        public void ClearBoxes() {
            foreach (Control ctr in Controls) {
                if (ctr is TextBox || ctr is NumericUpDown) {
                    ctr.Text = "";
                }
            }
        }

        public void DisableBtnUpdateDelete() {
            btnUpdateHotel.Enabled = false;
            btnDeleteHotel.Enabled = false;
        }

        public void EnableBtnUpdateDelete() {
            btnCreateHotel.Enabled = false;
            btnUpdateHotel.Enabled = true;
            btnDeleteHotel.Enabled = true;
        }

        private void Click_Window(object sender, EventArgs e) {
            ResetAll();
        }

        private void listViewHotels_SelectedIndexChanged(object sender, EventArgs e) {
            ResetAll();
        }

        private void ResetAll() {
            btnCreateHotel.Enabled = true;
            ClearBoxes();
            DisableBtnUpdateDelete();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            GetHotels("Activo");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            GetHotels("Inactivo");
        }
    }
}
