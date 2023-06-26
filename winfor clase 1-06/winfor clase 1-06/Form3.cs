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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alta();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alta();

            MessageBox.Show("Se agrego");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void alta()
        {
            MarcaCelular Nueva = new MarcaCelular();
            Nueva.id_marca = int.Parse(textBox1.Text);
            Nueva.namemarca = textBox2.Text;
            Nueva.Modelo = textBox3.Text;

            MarcaCelular.darmeMarca().Add(Nueva);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alto");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

