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

namespace Travel_agency {
    public partial class PanelAdmin : Form {

        User super_user;
        Form1 parent;

        List<Form> forms = new List<Form>();

        public PanelAdmin(User super_user, Form1 parent) {
            this.super_user = super_user;
            this.parent = parent;

            InitializeComponent();
            loadFormsList();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e) {

            closeForms();
            resetMenuItems();
            perfilToolStripMenuItem.Enabled = false;

            forms[0].MdiParent = this;
            forms[0].Show();
        }

        private void Close_Forms(object sender, FormClosingEventArgs e) {
            parent.Close();
        }

        // Evento click item (Sucursales)
        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e) {

            closeForms();
            resetMenuItems();
            sucursalesToolStripMenuItem.Enabled = false;
            forms[1].WindowState = System.Windows.Forms.FormWindowState.Maximized;
            forms[1].MdiParent = this;
            forms[1].Show();
        }

        private void resetMenuItems() {
            foreach (ToolStripMenuItem item in menuStrip1.Items) {
                item.Enabled = true;
            }
        }

        private void closeForms() {
            foreach (Form window in forms) {
                window.Hide();
            }
        }

        private void loadFormsList() {
            forms.Add(new Perfil(super_user, menuStrip1));
            forms.Add(new Sucursales());
        }


    }
}
