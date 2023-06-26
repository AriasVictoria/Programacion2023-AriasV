using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winfor_clase_1_06
{
    public partial class Form1 : Form
    {
        List<Carrito> Micarrito = new List<Carrito>();
        public Form1()
        {
            InitializeComponent();
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            Producto miproducto = new Producto();
            miproducto.marca_producto = txtmarca.Text;
            miproducto.precio_producto = double.Parse(txtprecio.Text);

            Micarrito.Add(miproducto);

            MessageBox.Show("Se ha agregado ese producto");

            //Acepta el producto agregado y limpia para poder agregar otro
            txtmarca.Text = "";
            txtprecio.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double costooapagar = 0;

            foreach (Carrito miproducto in Micarrito)
            {
                costooapagar = costooapagar + miproducto.dameCosto();
            }
            MessageBox.Show("debe pagar " + costooapagar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Servicio miservicio = new Servicio();
            miservicio.nombre = txtnombre.Text;
            miservicio.importe= double.Parse(txtimporte.Text);

            Micarrito.Add(miservicio);

            txtnombre.Text = "";
            txtimporte.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Seguro miseguro = new Seguro();
            miseguro.numeroPoliza = int.Parse(txtnumeropoliza.Text);
            miseguro.premio = double.Parse(txtpremio.Text);

            Micarrito.Add(miseguro);

            txtnumeropoliza.Text = "";
            txtpremio.Text = "";
        }
    }
}
