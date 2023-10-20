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

namespace Sistema_Financiero.Movimiento
{
    public partial class Transferencia : Form
    {
        Principal principal = new Principal();
        public Transferencia()
        {
            InitializeComponent();
        }

        private void Transferencia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movimientos form = new Movimientos();
            form.Show();
            this.Hide();
        }
    }
}
