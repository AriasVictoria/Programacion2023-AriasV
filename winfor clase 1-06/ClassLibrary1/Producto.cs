using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Producto : Carrito
    {
        public  int  codigo { get; set; }
        public  string marca_producto { get; set; }
        public  double precio_producto { get; set; }

        public double dameCosto()
        {
            return precio_producto;
        }
    }
}
