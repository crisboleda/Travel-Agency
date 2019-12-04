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
    public partial class Perfil : Form {

        User super_user;
        MenuStrip menu;
        UserManager _UserManager;

        public Perfil(User super_user, MenuStrip menu) {
            this.super_user = super_user;
            this.menu = menu;
            _UserManager = new UserManager();
            InitializeComponent();
            Init();
        }

        private void Init() {
            textBoxCedula.Text = super_user.GetCedula().ToString();
            textBoxRank.Text = super_user.GetRol();
            textBoxName.Text = super_user.GetName();
            textBoxLastname.Text = super_user.GetLastName();
            textBoxAddress.Text = super_user.GetAddress();
            textBoxCellphone.Text = super_user.GetCellphone();
            textBoxEmail.Text = super_user.GetEmail();
            textBoxPassword.Text = super_user.GetPassword();
        }


        private void Form_Closed(object sender, FormClosedEventArgs e) {
            menu.Items[3].Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) {
            btnUpdate.Enabled = false;
            textBoxName.Enabled = true;
            textBoxLastname.Enabled = true;
            textBoxAddress.Enabled = true;
            textBoxCellphone.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxPassword.Enabled = true;
            btnSaveChanges.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e) {

            btnSaveChanges.Enabled = false;
            btnUpdate.Enabled = true;
    
            User user_update = new User(
                Convert.ToInt32(textBoxCedula.Text.ToString()),
                textBoxName.Text.ToString(),
                textBoxName.Text.ToString(),
                textBoxLastname.Text.ToString(),
                textBoxAddress.Text.ToString(),
                textBoxCellphone.Text.ToString(),
                textBoxEmail.Text.ToString(),
                textBoxPassword.Text.ToString()
            );

            _UserManager.UpdateUser(user_update);

            foreach (Control ctr in Controls) {
                if (ctr is TextBox) {
                    ctr.Enabled = false;
                }
            }
        }
    }
}
