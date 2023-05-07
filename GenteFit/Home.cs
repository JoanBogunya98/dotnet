using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet_GenteFit
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();

            login.Show();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro Registro = new Registro();

            this.Hide();

            Registro.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
