using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProyectoDeAula
{
    public class Negocios
    {   
        private int codigo, contDep, contR;
        private double valorInversion, totalIngresos_3Annos,rentabilidad;
        private string nombreIdeaNegocio = "", impactoSocial_Economico = "", herramientas4RI = "";
        private List<IntegrantesNegocio> integrantes = new List<IntegrantesNegocio>();
        private List<string> negocioDepartamentos = new List<string>();
        private List<string> lista4RI = new List<string>();

        public Negocios(int codigo, double valorInversion, double totalIngresos_3Annos, string nombreIdeaNegocio, string impactoSocial_Economico)
        {
            this.Codigo = codigo;
            this.ValorInversion = valorInversion;
            this.TotalIngresos_3Annos = totalIngresos_3Annos;
            this.NombreIdeaNegocio = nombreIdeaNegocio;
            this.ImpactoSocial_Economico = impactoSocial_Economico;
            this.Herramientas4RI = herramientas4RI;
        }
        
        public int Codigo { get => codigo; set => codigo = value; }
        public int ContDep { get => contDep; set => contDep = value; }
        public double ValorInversion { get => valorInversion; set => valorInversion = value; }
        public double TotalIngresos_3Annos { get => totalIngresos_3Annos; set => totalIngresos_3Annos = value; }
        public double Rentabilidad { get => rentabilidad; set => rentabilidad = value; }
        public string NombreIdeaNegocio { get => nombreIdeaNegocio; set => nombreIdeaNegocio = value; }
        public string ImpactoSocial_Economico { get => impactoSocial_Economico; set => impactoSocial_Economico = value; }
        public string Herramientas4RI { get => herramientas4RI; set => herramientas4RI = value; }
        public List<IntegrantesNegocio> Integrantes { get => integrantes; set => integrantes = value; }
        public List<string> NegocioDepartamentos { get => negocioDepartamentos; set => negocioDepartamentos = value; }
        public List<string> Lista4RI { get => lista4RI; set => lista4RI = value; }

        
    }


}
