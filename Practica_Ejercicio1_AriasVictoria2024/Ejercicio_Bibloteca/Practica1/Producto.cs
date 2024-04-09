namespace Ejercicio_Bibloteca.Practica1
{
    public class Producto
    {
        public string Descripcion_Producto { get; set; }
        public int Precio_Producto { get; set; }
        public int stock { get; set; }
        
        public string tamaño { get; set; }
        public string TipoProducto { get; set; }

        public void altaProducto(Producto producto)
        {
            var producto1 = new Producto();
            producto1.Descripcion_Producto = "Producto 1";
            producto1.TipoProducto = "Herramienta";
            producto1.tamaño = "grande";
            producto1.Precio_Producto = 4500;
            producto1.stock = 3;

            var producto2 = new Producto();
            producto2.Descripcion_Producto = "Producto 2";
            producto2.TipoProducto = "insumo";
            producto2.tamaño = "mediano";
            producto2.Precio_Producto = 5200;
            producto2.stock = 6;

            var producto3 = new Producto();
            producto3.Descripcion_Producto = "Producto 3";
            producto3.TipoProducto = "Electricidad";
            producto3.tamaño = "chico";
            producto3.Precio_Producto = 6230;
            producto3.stock = 3;

            var productos = new List<Producto>();
            productos.Add(producto1);
            productos.Add(producto2);
            productos.Add(producto3);
        }

    }
}