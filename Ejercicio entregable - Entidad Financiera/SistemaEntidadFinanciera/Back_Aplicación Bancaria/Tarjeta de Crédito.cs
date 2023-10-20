using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations; // Asegúrate de importar este espacio de nombres


namespace Back_Aplicación_Bancaria
{
    public class Tarjeta_de_Crédito
    {
        public int Id { get; set; }
        public int numeroTarjeta { get; set; }
        public int limiteCredito { get; set; }
        public double saldoDisponible { get; set; }
        public string estado { get; set; }
        public double MontoDeuda { get; set; }
        public Cliente DueñoTarjeta { get; set; }

    }
}
