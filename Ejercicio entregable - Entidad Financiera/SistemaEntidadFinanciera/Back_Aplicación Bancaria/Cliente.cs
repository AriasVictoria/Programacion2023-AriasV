using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;

namespace Back_Aplicación_Bancaria
{
    public class Cliente
    {
        
        public int Id { get; set; }
        public string  Nombre_cliente { get; set; }
        public string Apellido_cliente { get; set; }
        public int DNI { get; set; }
        public override string ToString()
        {
            return Id + DNI + Nombre_cliente + Apellido_cliente;
        }
    }
}
