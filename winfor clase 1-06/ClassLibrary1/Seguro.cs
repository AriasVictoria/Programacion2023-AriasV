using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Seguro : Carrito
    {
        public int numeroPoliza { get; set; }
        public double premio { get; set; }
        public double dameCosto()
        {
            return premio;
        }
    }
}
