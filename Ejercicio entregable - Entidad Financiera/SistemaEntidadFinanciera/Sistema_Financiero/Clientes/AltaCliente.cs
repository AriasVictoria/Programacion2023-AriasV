using Back_Aplicación_Bancaria;
using Sistema_Financiero.Cuenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financiero
{
    public partial class AltaCliente : Form
    {
        Principal principal = new Principal();
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, Cliente cliente)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e, Cliente cliente)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Cliente cliente = new Cliente();

            cliente.Id = int.Parse(textBox1.Text);
            cliente.DNI = int.Parse(textBox2.Text);
            cliente.Nombre_cliente = textBox3.Text;
            cliente.Apellido_cliente = textBox4.Text;

            principal.AltaCliente(cliente);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = cliente;
            dataGridView1.DataSource = aBind;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("agregado con exito");
        }
    }
}
