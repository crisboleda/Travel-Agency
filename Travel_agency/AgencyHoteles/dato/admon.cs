using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_agency.Hoteles.modelo;

namespace Travel_agency.Hoteles.dato
{
    public class admon
    {
        List<hotelModel> lista = new List<hotelModel>();
        public void Guardar(hotelModel modelo)
        {
            lista.Add(modelo);
        }

        public List<hotelModel> Consultar()
        {
            return lista;
        }
    }
}
