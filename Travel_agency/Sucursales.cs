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

namespace Travel_agency {

    public partial class Sucursales : Form {

        private SucursalManager _SucursalManager;
        List<Sucursal> listSucursales;

        public Sucursales() {
            InitializeComponent();
            Init();
        }

        private void Init() {
            _SucursalManager = new SucursalManager();
            DisableBtnUpdateDelete();
            GetSucursales();
        }

        // Método para listar todas las sucursales de la base de datos
        private void GetSucursales() {

            listViewSucursales.Items.Clear();
            listSucursales = _SucursalManager.GetSucursales();

            foreach (Sucursal sucursal in listSucursales) {

                // Creamos una fila y le agregamos un identificador
                ListViewItem item2 = listViewSucursales.Items.Add(sucursal.GetIDSucursal().ToString());

                // Apartir de la fila creada creamos las columnas de la fila
                item2.SubItems.Add(sucursal.GetAddress());
                item2.SubItems.Add(sucursal.GetCellphone());
            }
        }

        private void btnCreateSucursal_Click(object sender, EventArgs e) {

            if (textBoxAddres.Text != "" && textBoxCellphone.Text != "") {
                _SucursalManager.CreateSucursal(textBoxAddres.Text.ToString(), textBoxCellphone.Text.ToString());
                clearBoxes();
                GetSucursales();
            }
        }

        private void clearBoxes() {
            textBoxID.Text = "";
            textBoxAddres.Text = "";
            textBoxCellphone.Text = "";
        }

        private void Mouse_Click(object sender, MouseEventArgs e) {

            btnCreateSucursal.Enabled = false;
            btnUpdateSucursal.Enabled = true;
            btnDeleteSucursal.Enabled = true;

            for (int i = 0; i < listViewSucursales.Items.Count; i++) {

                var rectangle = listViewSucursales.GetItemRect(i);
                if (rectangle.Contains(e.Location)) {
                    textBoxID.Text = listSucursales[i].GetIDSucursal().ToString();
                    textBoxAddres.Text = listSucursales[i].GetAddress();
                    textBoxCellphone.Text = listSucursales[i].GetCellphone();
                }
            }
        }

        private void btnUpdateSucursal_Click(object sender, EventArgs e) {

            if (textBoxID.Text != "" && textBoxAddres.Text != "" && textBoxCellphone.Text != "") {
                _SucursalManager.UpdateSucursal(Convert.ToInt32(textBoxID.Text), textBoxAddres.Text, textBoxCellphone.Text);
                clearBoxes();
                GetSucursales();
                DisableBtnUpdateDelete();
            }
        }

        private void btnDeleteSucursal_Click(object sender, EventArgs e) {

            if (textBoxID.Text != "" && textBoxAddres.Text != "" && textBoxCellphone.Text != "") {
                _SucursalManager.DeleteSucursal(Convert.ToInt32(textBoxID.Text));
                clearBoxes();
                GetSucursales();
                DisableBtnUpdateDelete();
            }

        }

        private void listViewSucursales_SelectedIndexChanged(object sender, EventArgs e) {
            clearBoxes();
            DisableBtnUpdateDelete();
        }

        private void Click_Window(object sender, EventArgs e) {
            clearBoxes();
            DisableBtnUpdateDelete();
        }

        private void DisableBtnUpdateDelete() {
            btnCreateSucursal.Enabled = true;
            btnUpdateSucursal.Enabled = false;
            btnDeleteSucursal.Enabled = false;
        }
    }
}
