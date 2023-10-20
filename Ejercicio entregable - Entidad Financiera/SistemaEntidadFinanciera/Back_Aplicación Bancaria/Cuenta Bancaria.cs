using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;

namespace Back_Aplicación_Bancaria
{
    public class Cuenta_Bancaria
    {
        public int Id { get; set; }
        public int Numero_Cuenta { get; set; }
        public double saldo { get; set; }
        public string tipo_cuenta { get; set; }
        public Cliente Dueño { get; set; }
    }
}
