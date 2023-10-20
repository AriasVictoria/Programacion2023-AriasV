using Back_Aplicación_Bancaria;
using Sistema_Financiero.Cuenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financiero
{
    public partial class PantallaCuenta : Form
    {
        Principal principal = new Principal();
        public PantallaCuenta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Movimientos movimientos = new Movimientos();
            movimientos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuenta_Bancaria cuenta = new Cuenta_Bancaria();

            cuenta.Dueño = cuenta.Dueño;
            cuenta.tipo_cuenta = textBox2.Text;
            cuenta.Numero_Cuenta = int.Parse(textBox3.Text);
            cuenta.saldo = int.Parse(textBox4.Text);

            principal.CrearCuenta(cuenta);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = cuenta;
            dataGridView1.DataSource = aBind;

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("agregado con exito");
        }

        private void PantallaCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
