using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Celular : Carrito
    {
        public int Precio { get; set; }
        public string numero { get; set; }
        public MarcaCelular marca { get; set; } //OBJETO DENTRO DE OTRO (COMPOSICIÓN DE CLASES)

        public double dameCosto()
        {
            return Precio;
        }
    }
}
