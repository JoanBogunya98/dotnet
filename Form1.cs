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

            if (baseDatos.conectar()) msgText.Text = "Conexión con éxito a la BBDD";
        }
    }
}