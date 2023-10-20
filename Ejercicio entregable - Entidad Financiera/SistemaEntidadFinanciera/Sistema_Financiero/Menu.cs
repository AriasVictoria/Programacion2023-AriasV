using Sistema_Financiero.Tarjeta;

namespace Sistema_Financiero
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void realizarDepositoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaCliente clientes1 = new AltaCliente();
            clientes1.Show();
            this.Hide();
        }

        private void agregarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaCuenta cuenta = new PantallaCuenta();
            cuenta.Show();
            this.Hide();
        }

        private void tarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaTarjeta tarjeta = new PantallaTarjeta();
            tarjeta.Show();
            this.Hide();
        }
    }
}