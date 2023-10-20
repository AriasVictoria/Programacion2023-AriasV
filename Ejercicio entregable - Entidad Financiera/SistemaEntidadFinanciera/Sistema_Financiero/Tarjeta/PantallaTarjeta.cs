using Back_Aplicación_Bancaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financiero.Tarjeta
{
    public partial class PantallaTarjeta : Form
    {
        Principal principal = new Principal();
        public PantallaTarjeta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarjeta_de_Crédito tarjeta = new Tarjeta_de_Crédito();

            tarjeta.Id = int.Parse(textBox1.Text);
            tarjeta.numeroTarjeta = int.Parse(textBox2.Text);
            tarjeta.limiteCredito = int.Parse(textBox3.Text);
            tarjeta.estado = textBox4.Text;

            principal.EmitirTarjeta(tarjeta);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = tarjeta;
            dataGridView1.DataSource = aBind;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            MessageBox.Show("agregado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
