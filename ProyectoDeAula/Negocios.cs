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
        private double valorInversion, totalIngresos_3Annos;
        private string nombreIdeaNegocio = "", impactoSocial_Economico, herramientas4RI;
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

        public Negocios(int codigo, double valorInversion, double totalIngresos_3Annos, string nombreIdeaNegocio, string impactoSocial_Economico, string herramientas4RI)
        {
            this.Codigo = codigo;
            this.ValorInversion = valorInversion;
            this.TotalIngresos_3Annos = totalIngresos_3Annos;
            this.NombreIdeaNegocio = nombreIdeaNegocio;
            this.ImpactoSocial_Economico = impactoSocial_Economico;
            this.Herramientas4RI = herramientas4RI;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public double ValorInversion { get => valorInversion; set => valorInversion = value; }
        public double TotalIngresos_3Annos { get => totalIngresos_3Annos; set => totalIngresos_3Annos = value; }
        public string NombreIdeaNegocio { get => nombreIdeaNegocio; set => nombreIdeaNegocio = value; }
        public string ImpactoSocial_Economico { get => impactoSocial_Economico; set => impactoSocial_Economico = value; }
        public string Herramientas4RI { get => herramientas4RI; set => herramientas4RI = value; }
        public List<string> Departamentos { get => departamentos; set => departamentos = value; }
    }

}
