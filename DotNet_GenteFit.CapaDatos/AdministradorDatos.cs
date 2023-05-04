using DotNet_GenteFit.CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DotNet_GenteFit.CapaDatos
{
    public class AdministradorDatos
    {
        private readonly string fileName;

        public AdministradorDatos(string file)
        {
            this.fileName = file;
        }

        public Administrador BuscarAdmin(string usuario, string contraseña)
        {
            return LeerAdministradores().FirstOrDefault(a => a.UsernameAdmin == usuario && a.PasswordAdmin == contraseña);
        }

        public List<Administrador> LeerAdministradores()
        {
            //CrearFicheroXml();
            var xml = new XmlSerializer(typeof(List<Administrador>));
            using var file = File.OpenRead(fileName);
            return (List<Administrador>)xml.Deserialize(file);
        }

        //private void CrearFicheroXml()
        //{
        //    var xml = new XmlSerializer(typeof(List<Administrador>));
        //    using var file = File.Create(fileName);
        //    xml.Serialize(file, new List<Administrador> {
        //        new Administrador {  EmailAdmin="email", IdAdmin=1, PasswordAdmin="pass", UsernameAdmin="user"} ,
        //            new Administrador {  EmailAdmin="email2", IdAdmin=2, PasswordAdmin="pass2", UsernameAdmin="user2"}
        //    });
        //}
    }
}
