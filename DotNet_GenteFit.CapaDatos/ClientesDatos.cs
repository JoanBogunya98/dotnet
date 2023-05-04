using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.CapaDatos.Infraestructura;
using DotNet_GenteFit.CapaDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_GenteFit.CapaDatos
{
    public class ClientesDatos
    {
        private readonly IDbFactory context;

        public ClientesDatos() : this(new DbFactory()) { }

        public ClientesDatos(IDbFactory context)
        {
            this.context = context;
        }

        public Cliente BuscaCliente(string usuario, string contraseña)
        {
            using var db = this.context.GetContext();
            return db.Clientes.FirstOrDefault(c => c.UsernameCliente == usuario && c.PasswordCliente == contraseña);

        }

        public void NuevoCliente(Cliente nuevoCliente)
        {
            using var db = this.context.GetContext();
            db.Clientes.Add(nuevoCliente);
            db.SaveChanges();
        }
    }
}
