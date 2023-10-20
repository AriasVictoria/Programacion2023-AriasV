using Back_Aplicación_Bancaria;
using Sistema_Financiero.Movimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financiero.Cuenta
{
    public partial class Movimientos : Form
    {
        Principal Principal { get; set; }
        public Movimientos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito();
            deposito.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transferencia transferencia1 = new Transferencia();
            transferencia1.Show();
            this.Hide();
        }
    }
}
