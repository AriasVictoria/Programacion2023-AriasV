using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MarcaCelular
    {
        public int id_marca { get; set; }
        public string namemarca { get; set;}
        public string Modelo { get; set; }

        public static List<MarcaCelular> BaseMarca; 
        public static void removeThisMarca(MarcaCelular marcaBorrar)
        {
            darmeMarca().Remove(marcaBorrar);
        }

        public static List<MarcaCelular> darmeMarca() //metodo que guarda su inf en la BD
        { 
            //static el mensaje no puede alterar los valores de los objetos 
            //se crea el metodo estatico cuando quiero objetos que estan dentro del molde 
            List<MarcaCelular> listita = new List<MarcaCelular>();

            if (BaseMarca == null)
            {
                BaseMarca = new List<MarcaCelular>();

                MarcaCelular marca1 = new MarcaCelular();
                marca1.id_marca = 1;
                marca1.namemarca = "Samsung";
                BaseMarca.Add(marca1);

                MarcaCelular marca2 = new MarcaCelular();
                marca2.id_marca = 2;
                marca2.namemarca = "Apple";
                BaseMarca.Add(marca2);

                MarcaCelular marca3 = new MarcaCelular();
                marca3.id_marca = 3;
                marca3.namemarca = "Huawmei";
                BaseMarca.Add(marca3);

            }
            return BaseMarca;
        }
    }
}
