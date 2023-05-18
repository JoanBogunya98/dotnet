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
    public partial class ModificarAdmin : Form
    {
        public ModificarAdmin()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            CursosAdmin CursosAdmin = new CursosAdmin();

            this.Hide();

            CursosAdmin.Show();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
        }

    }

}
