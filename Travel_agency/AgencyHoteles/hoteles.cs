using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_agency.Hoteles.dato;
using Travel_agency.Hoteles.modelo;

namespace Travel_agency.Hoteles
{
    public partial class hoteles : Form
    {
        DataTable tabla;
        admon dato = new admon();

        public hoteles()
        {
            InitializeComponent();
            iniciar();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            guardar();
            iniciar();
            limpiar();
            Consultar();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre del Hotel");
            tabla.Columns.Add("Codigo del Hotel");
            tabla.Columns.Add("Ciudad");
            grilla.DataSource = tabla;

        }

        private void guardar()
        {
            hotelModel modelo = new hotelModel()
            {
                Nombre = txtNombreHotel.Text,
                Codigo = textCodigoHotel.Text,
                ciudad = textHotel.Text
            };
            dato.Guardar(modelo);
        }
        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila[0] = item.Nombre;
                fila[1] = item.Codigo;
                fila[2] = item.ciudad;
                tabla.Rows.Add(fila);
            }
        }

        private void limpiar()
        {
            textNombreHotel.Text = "";
            textCodigoHotel.Text = "";
            textHotel.Text = "";

        }
    }
}
