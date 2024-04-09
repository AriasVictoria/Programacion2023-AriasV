using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Bibloteca.Practica1
{
    public class Venta
    {
        public int id {  get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoTotal { get; set; }
        public List<Producto> Productos { get; set; }
        public List<int> Cantidad { get; set; }

        public Venta(Cliente cliente, DateTime fecha, List<Producto> productos, List<int> cantidad)
        {
            Cliente = cliente;
            Fecha = fecha;
            Productos = productos;
            Cantidad = cantidad;

            MontoTotal = 0;

        }
    }
}
