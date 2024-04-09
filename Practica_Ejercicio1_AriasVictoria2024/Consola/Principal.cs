using Ejercicio_Bibloteca.Practica1;
using Ejercicio_Bibloteca.Practica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Principal
    {
        static void Main(string[] args)
        {
            Ejercicio_Bibloteca.Practica1.Cliente cliente = new Ejercicio_Bibloteca.Practica1.Cliente();
            cliente.NombreCliente = "Arias Victoria";
            cliente.Dni_Cliente = "45353230";
            cliente.Correo = "victoria.arias.ices@gmai.com";

            List<Venta> ventas = new List<Venta>();

            var producto1 = new Producto();
            producto1.Descripcion_Producto = "Martillo";
            producto1.TipoProducto = "Herramienta";
            producto1.tamaño = "grande";
            producto1.Precio_Producto = 4500;
            producto1.stock = 3;

            var producto2 = new Producto();
            producto2.Descripcion_Producto = "Papel";
            producto2.TipoProducto = "insumo";
            producto2.tamaño = "mediano";
            producto2.Precio_Producto = 5200;
            producto2.stock = 6;

            List<Producto> productosComprados = new List<Producto>();
            productosComprados.Add(producto1);
            productosComprados.Add(producto2);
            List<int> cantidadesCompradas = new List<int>();
            cantidadesCompradas.Add(3);
            cantidadesCompradas.Add(4);

            Venta venta1 = new Venta(cliente, DateTime.Now, productosComprados, cantidadesCompradas);
            ventas.Add(venta1);

            Console.WriteLine($"Nombre:  {cliente.NombreCliente}- Dni: {cliente.Dni_Cliente}- Correo: {cliente.Correo}");
            Console.WriteLine($"Descripción: {ventas[0].Productos[0].Descripcion_Producto} - Tipo: {ventas[0].Productos[0].TipoProducto}" +
                $"-tamaño: {ventas[0].Productos[0].tamaño}- Precio: {ventas[0].Productos[0].Precio_Producto}");
            Console.WriteLine(ventas[0].Cantidad[0]);
            Console.WriteLine($"Descripción: {ventas[0].Productos[1].Descripcion_Producto} - Tipo: {ventas[0].Productos[1].TipoProducto}" +
                $"-tamaño: {ventas[0].Productos[1].tamaño}- Precio: {ventas[0].Productos[1].Precio_Producto}");
            Console.WriteLine(ventas[0].Cantidad[1]);

        }

    }

}
