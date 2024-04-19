using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Calculadora
    {
        public double Suma(double numero1, double numero2)
        {
            return numero1 + numero2;
        }
        public double Restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }
        public double Multiplicacion(double numero1, double numero2)
        {
            return numero1 + numero2;
        }
        public double Division(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                return 0;
            }
            else
            {
                return numero1 / numero2;
            }
        }
    }
}
