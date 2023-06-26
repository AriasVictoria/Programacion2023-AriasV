using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Servicio : Carrito
    {
        public  int codigo_servicio { get; set; }
        public  string nombre { get; set; }
        public double importe { get; set;}

        public double dameCosto()
        {
            return importe;
        }
    }
}
