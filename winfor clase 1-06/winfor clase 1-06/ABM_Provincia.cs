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
    public partial class ABM_Provincia : Form
    {
        public ABM_Provincia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Provincia Provincia1 = new Provincia();
            Provincia1.IdP = int.Parse(textBox1.Text);
            Provincia1.Nombre_P = textBox2.Text;

            Provincia.dameProvincia().Add(Provincia1);
            MessageBox.Show("Se agrego una provincia" + Provincia1.Nombre_P);

            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
