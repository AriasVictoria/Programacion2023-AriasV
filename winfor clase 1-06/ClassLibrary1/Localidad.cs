using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Localidad
    {
        public string Nombre_L { get; set; }
        public Provincia Provincias { get; set; }

        public static List<Localidad> Lista_Localidad { get; set; }

        public static List<Localidad> dameLocalidad()
        {
            if (Lista_Localidad == null)
            {
                Lista_Localidad = new List<Localidad>();

                Localidad Localidad1 = new Localidad();
                Localidad1.Nombre_L= "Sacanta";
                Lista_Localidad.Add(Localidad1);

                Localidad Localidad2= new Localidad();
                Localidad2.Nombre_L = "Sunchales";
                Lista_Localidad.Add(Localidad2);

                Localidad Localidad3 = new Localidad();
                Localidad3.Nombre_L = "San Rafael";
                Lista_Localidad.Add(Localidad3);
            }
            return Lista_Localidad;
        }
    }
}
