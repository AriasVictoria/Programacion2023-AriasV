using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_Aplicación_Bancaria
{
    public class BaseDatos : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta_Bancaria> Cuentas { get; set; }
        public DbSet<Tarjeta_de_Crédito> Tarjetas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=VARIAS\\SQLEXPRESS;database=BD_Financiera;trusted_connection=true;Encrypt=False");
        }
    }
}
