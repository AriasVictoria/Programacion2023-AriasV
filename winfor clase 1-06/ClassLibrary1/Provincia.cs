using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Provincia
    {
        public string Nombre_P { get; set; }
        public int IdP { get; set; }
        public Pais Pais { get; set; }
        public List<Pais> Paises { get; set; }  

        public static List<Provincia> Lista_Provincia { get; set;}

        public static List<Provincia> dameProvincia()
        {
            if (Lista_Provincia == null)
            {
                Lista_Provincia = new List<Provincia>();

                Provincia Provincia1 = new Provincia();
                Provincia1.IdP = 1;
                Provincia1.Nombre_P = "Cordoba";
                Lista_Provincia.Add(Provincia1);

                Provincia Provincia2 = new Provincia();
                Provincia2.IdP = 2;
                Provincia2.Nombre_P = "Santa fe";
                Lista_Provincia.Add(Provincia2);

                Provincia Provincia3 = new Provincia();
                Provincia3.IdP = 3;
                Provincia3.Nombre_P = "Mendoza";
                Lista_Provincia.Add(Provincia3);
            }
            return Lista_Provincia;
        }
    }
}
