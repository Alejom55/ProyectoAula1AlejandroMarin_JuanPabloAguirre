using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeAula
{
    internal class IntegrantesNegocio
    {
        private string Id, nombre, apellidos, rolEpmprendimiento, email;

        public IntegrantesNegocio(string id, string nombre, string apellidos, string rolEpmprendimiento, string email)
        {
            Id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.rolEpmprendimiento = rolEpmprendimiento;
            this.email = email;
        }
    }
}
