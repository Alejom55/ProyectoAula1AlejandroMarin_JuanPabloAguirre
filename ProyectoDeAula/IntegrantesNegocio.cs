using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeAula
{
    public class IntegrantesNegocio
    {
        private string id, nombre, apellidos, rolEpmprendimiento, email;

        public IntegrantesNegocio(string id, string nombre, string apellidos, string rolEpmprendimiento, string email)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.RolEpmprendimiento = rolEpmprendimiento;
            this.Email = email;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string RolEpmprendimiento { get => rolEpmprendimiento; set => rolEpmprendimiento = value; }
        public string Email { get => email; set => email = value; }
    }
}
