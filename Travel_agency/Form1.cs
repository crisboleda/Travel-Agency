using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_agency.AgencyUser;


namespace Travel_agency {
    public partial class Form1 : Form {

        private UserManager _UserManager;
        private Util utils = new Util();

        public Form1() {
            InitializeComponent();
            Init();
        }

        // Instancio un manejador del CRUD de usuarios
        private void Init() {
            _UserManager = new UserManager();
        }

        // Botón de Loguerar
        private void btnLogin_Click(object sender, EventArgs e) {
            string email = textBoxEmail.Text.ToString();
            string password = textBoxPassword.Text.ToString();

            // Invoco el metodo de iniciar sesión (Si existe el usuario) me devuelve un objeto de User, de lo contrario Null
            User super_user = _UserManager.SignIn(email, password);
            
            if (super_user == null) {

                textBoxEmail.Text = "";
                textBoxPassword.Text = "";

                errorSignIn.Text = "Password or Email Incorrect";

            }else {
                if (super_user.GetRol() == "Admin") {
                    Hide();
                    PanelAdmin view_admin = new PanelAdmin(super_user, this);
                    view_admin.Show();

                }else {
                    Hide();
                    PanelTurista viewTurista = new PanelTurista(super_user, this);
                    viewTurista.Show();
                }
            }
        }

        // Evento de click en el botón de registrar
        private void btnSignUp_Click(object sender, EventArgs e) {

            string cedula = textBoxCedula.Text.ToString();
            string name = textBoxName.Text.ToString();
            string lastName = textBoxLastName.Text.ToString();
            string address = textBoxAddress.Text.ToString();
            string cellphone = textBoxPhone.Text.ToString();
            string email = textBoxEmailReg.Text.ToString();
            string password = textBoxPasswordReg.Text.ToString();


            // Comprobar que haya llenado todos los campos del formulario de registro.
            if (email != "" && password != "" && cedula != "" && name != "" && address != "" && lastName != "") {

                if (utils.checkEmail(email)) {
                    User new_user = new User(Convert.ToInt32(cedula), "Turista", name, lastName, address, cellphone, email, password);
                    _UserManager.CreateUser(new_user);
                    MessageBox.Show("Se regristró correctamente, Ahora inicie sesión");
                    clearBoxes();

                }else {
                    MessageBox.Show("El correo electronico no es correcto, ingrese uno correo valido");
                    clearBoxes();
                }

            }
        }

        private void clearBoxes() {
            foreach (Control ctr in Controls) {
                if (ctr is TextBox) {
                    ctr.Text = "";
                }
            }
        }
    }
}
