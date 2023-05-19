using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet_GenteFit.Servicios
{
    public class ServicioNavegacion
    {
        internal void Logout()
        {
            var list = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                list.Add(form);
            }
            var closeAll = false;
            list.ForEach(n =>
            {
                if (n is Home && !closeAll)
                {
                    n.Show();
                    closeAll = true;
                }
                else
                {
                    n.Close();
                }
            });
        }
    }
}
