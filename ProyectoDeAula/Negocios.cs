using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeAula
{
    public class Negocios
    {   
        private int codigo;
        private double valorInversion, totalIngresos_3Annos;
        private string nombreIdeaNegocio = "", impactoSocial_Economico = "", herramientas4RI = "";
        private List<string> departamentos = new List<string>
        {
            "1.Amazonas", "2.Antioquia", "3.Arauca", "4.Atlántico",
            "5.Bolívar", "6.Boyacá", "7.Caldas", "8.Caquetá", "9.Casanare",
            "10.Cauca", "11.Cesar", "Chocó", "Córdoba", " Cundinamarca",
            "Guainía", "Guaviare", "Huila", "La Guajira", "Magdalena",
            "Meta", "Nariño", "Norte de Santander", "Putumayo", "Quindío",
            "Risaralda", "San Andrés y Providencia", "Santander", "Sucre", "Tolima",
            "Valle del Cauca", "Vaupés", "Vichada"
        };
        private List<Negocios> listaNegocios = new List<Negocios>();
        private List<int> listaCodigoNegocios = new List<int>();
        private List<string> listaHerramientas4RI = new List<string>
        {
            "Inteligencia artificial", "Cloud computing",
            "Biometria", "Firma digital"
        };

        public Negocios(int codigo, double valorInversion, double totalIngresos_3Annos, string nombreIdeaNegocio, string impactoSocial_Economico)
        {
            this.Codigo = codigo;
            this.ValorInversion = valorInversion;
            this.TotalIngresos_3Annos = totalIngresos_3Annos;
            this.NombreIdeaNegocio = nombreIdeaNegocio;
            this.ImpactoSocial_Economico = impactoSocial_Economico;
            this.Herramientas4RI = herramientas4RI;
            List<IntegrantesNegocio> integrantes = new List<IntegrantesNegocio>();
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public double ValorInversion { get => valorInversion; set => valorInversion = value; }
        public double TotalIngresos_3Annos { get => totalIngresos_3Annos; set => totalIngresos_3Annos = value; }
        public string NombreIdeaNegocio { get => nombreIdeaNegocio; set => nombreIdeaNegocio = value; }
        public string ImpactoSocial_Economico { get => impactoSocial_Economico; set => impactoSocial_Economico = value; }
        public string Herramientas4RI { get => herramientas4RI; set => herramientas4RI = value; }
        public List<string> Departamentos { get => departamentos; set => departamentos = value; }
        public List<string> ListaHerramientas4RI { get => listaHerramientas4RI; set => listaHerramientas4RI = value; }
        internal List<Negocios> ListaNegocios { get => listaNegocios; set => listaNegocios = value; }
        internal List<int> ListaCodigoNegocios { get => ListaCodigoNegocios; set => listaCodigoNegocios = value; }
    }


}
