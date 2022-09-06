using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeAula
{
    class Negocios
    {
        private int codigo;
        private string nombreIdeaNegocio = "", impactoSocial_Economico = "";
        private List<string> departamentos = new List<string>
        {
            "Amazonas", "Antioquia", "Arauca", "Atlántico",
            "Bolívar", "Boyacá", "Caldas", "Caquetá", "Casanare",
            "Cauca", "Cesar", "Chocó", "Córdoba", " Cundinamarca",
            "Guainía", "Guaviare", "Huila", "La Guajira", "Magdalena",
            "Meta", "Nariño", "Norte de Santander", "Putumayo", "Quindío",
            "Risaralda", "San Andrés y Providencia", "Santander", "Sucre", "Tolima",
            "Valle del Cauca", "Vaupés", "Vichada"
        };

        public Negocios(int codigo, string nombreIdeaNegocio)
        {
            this.codigo = codigo;
            this.nombreIdeaNegocio = nombreIdeaNegocio;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string NombreIdeaNegocio { get => nombreIdeaNegocio; set => nombreIdeaNegocio = value; }
        public List<string> Departamentos { get => departamentos; set => departamentos = value; }
    }

}
