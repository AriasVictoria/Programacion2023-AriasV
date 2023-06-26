using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winfor_clase_1_06
{
    public partial class Form2 : Form
    {
        private List<Carrito> micarro = new List<Carrito> ();
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se puede poner una lista de cosas y el usuario elije una sola
            //vamos a porbar si el combo funciona
            string Elegido = comboBox1.SelectedItem.ToString();
            //el seguro tiene numero de poliza
            //el servicio tiene nombre
            //el producto tiene marca

            if (Elegido == "seguro")
            {
                label2.Text = "numero poliza";
            }
            else
            {
                if (Elegido == "Producto")
                {
                    label2.Text = "marca";
                }
                else
                {
                    label2.Text = "nombre";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Elegido = comboBox1.SelectedItem.ToString();
            //el seguro tiene numero de poliza
            //el servicio tiene nombre
            //el producto tiene marca

            if (Elegido == "seguro")
            {
                Seguro miseguro = new Seguro();
                miseguro.numeroPoliza = int.Parse(textBox1.Text);
                miseguro.premio = double.Parse(textBox2.Text);
                micarro.Add(miseguro);
            }
            else
            {
                if (Elegido == "Producto")
                {
                    Producto miproducto = new Producto();
                    miproducto.marca_producto = textBox1.Text;
                    miproducto.precio_producto = double.Parse(textBox2.Text);
                    micarro.Add(miproducto);
                }
                else
                {
                    Servicio miservicio = new Servicio();
                    miservicio.nombre = textBox1.Text;
                    miservicio.importe = double.Parse(textBox2.Text);
                    micarro.Add(miservicio);
                }
            }
            MessageBox.Show("Me seleccionaste: " + Elegido);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
             * comboBox1.Items.Add("Producto");
            comboBox1.Items.Add("Servicio");
            comboBox1.Items.Add("Seguro");
           
            List<MarcaCelular> lalistacombox = MarcaCelular.darmeMarca();
            comboBox1.Items.AddRange(lalistacombox.ToArray());
            comboBox1.DisplayMember = "namemarca";
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double costooapagar = 0;

            foreach (Carrito miproducto in micarro)
            {
                costooapagar = costooapagar + miproducto.dameCosto();
            }
            MessageBox.Show("debe pagar " + costooapagar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Celular micelu = new Celular();
            List<MarcaCelular> lalista = MarcaCelular.darmeMarca();
            micelu.Precio = int.Parse(textBox1.Text);
            micelu.numero = textBox1.Text;
            micelu.marca = (MarcaCelular)comboBox1.SelectedItem;

            MessageBox.Show("Me generaste un celu de la marca " + micelu.marca.namemarca);

            //PASO A PASO

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese");
            comboBox1.Items.AddRange(MarcaCelular.darmeMarca().ToArray());

            MarcaCelular marca4 = new MarcaCelular();
            marca4.id_marca = int.Parse(textBox1.Text);
            marca4.namemarca = "LG";
            MarcaCelular.darmeMarca().Add(marca4);

            MessageBox.Show("Termine");
        }
    }
}
