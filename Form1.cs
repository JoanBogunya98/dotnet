using System.Text;
using System.Net.NetworkInformation;
using DotNet_GenteFit.DDBB;

namespace DotNet_GenteFit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DB baseDatos = new DB();

            if (baseDatos.conectar()) comprobacionBd.Text = "Conexi�n con �xito a la BBDD";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}