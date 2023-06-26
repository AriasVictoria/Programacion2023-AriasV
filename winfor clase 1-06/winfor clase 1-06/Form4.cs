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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MarcaCelular.darmeMarca();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 mifor = new Form3();
            mifor.ShowDialog();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MarcaCelular.darmeMarca();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Hola ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PRIMERO MIRO CON ES EL ID DEL QUE ESTA SELECCIONADO 
            MarcaCelular Elegido = (MarcaCelular)dataGridView1.CurrentRow.DataBoundItem;
            if (Elegido != null)
            {

                MessageBox.Show("Me elejiste: " + Elegido.ToString());
            }
            else
            {
                MessageBox.Show("No hay elegidos");
            }
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = MarcaCelular.darmeMarca();
            
        }
    }
}
