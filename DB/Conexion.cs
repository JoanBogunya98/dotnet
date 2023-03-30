using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DotNet_GenteFit.DB {
    internal class DB {
        
        SqlConnection db;

        public DB() {
            this.db = new SqlConnection("Server=DESKTOP-VHM9FJ7\\SQLEXPRESS;Database=GentefitDatabase;User Id=Usuario;Password=;");
        }

        public bool conectar() {
            try {
                this.db.Open();
                return true;
            } catch(SqlException ex) { 
                return false;
            }
        }

        public void desconectar() {
            this.db.Close();
        }

    }

}
