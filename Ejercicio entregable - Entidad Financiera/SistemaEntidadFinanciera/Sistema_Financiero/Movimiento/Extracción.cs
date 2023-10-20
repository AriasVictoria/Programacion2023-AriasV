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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Financiero.Movimiento
{
    public partial class Extracción : Form
    {
        Principal principal = new Principal();
        public Extracción()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {

            }
            else
            {
                string mensaje = principal.RealizarExtracción(int.Parse(textBox5.Text), int.Parse(textBox2.Text));
                MessageBox.Show(mensaje);
                textBox5.Clear();
                textBox2.Clear();
            }
            MessageBox.Show("Extracción realizada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movimientos form = new Movimientos();
            form.Show();
            this.Hide();
        }
    }
}
