using ProyectoDeAula;
using System;

namespace repeat_string_x_times
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> listaCodigoNegocios = new List<int>();
            List<IntegrantesNegocio> listaIntegrantesNegocios = new List<IntegrantesNegocio>();
            List<Negocios> listaNegocios = new List<Negocios>();
            List<string> departamentos = new List<string>
            {
                "Amazonas", "Antioquia", "Arauca", "Atlántico",
                "Bolívar", "Boyacá", "Caldas", "Caquetá", "Casanare",
                "Cauca", "Cesar", "Chocó", "Córdoba", " Cundinamarca",
                "Guainía", "Guaviare", "Huila", "La Guajira", "Magdalena",
                "Meta", "Nariño", "Norte de Santander", "Putumayo", "Quindío",
                "Risaralda", "San Andrés y Providencia", "Santander", "Sucre", "Tolima",
                "Valle del Cauca", "Vaupés", "Vichada"
            };

            string separador = new string('*', 45);
            Console.WriteLine(separador);
            Console.WriteLine("BIENVENIDO A EMPRENDIMIENTOS CON HERRAMIENTAS \n DE LA CUARTA REVOLUCIÓN INDUSTRIAL (4RI)");
            Console.WriteLine(separador);
            Console.WriteLine("¿Que desea hacer?");
            bool aux = false;
            do
            {
                Console.WriteLine("1. Agregar Negocio");
                int respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 1)
                {
                    aux = true;
                    Console.WriteLine("¿Cuantos negocios desea agregar?");
                    int respCantidadNegocios = Convert.ToInt32(Console.ReadLine());
                    for(int cantNegocios = 1; cantNegocios <= respCantidadNegocios; cantNegocios++)
                    {
                        bool aux2 = false;
                        int codigo;
                        do
                        {
                            codigo = new Random().Next(1000, 10000);
                            if (!listaCodigoNegocios.Contains(codigo))
                            {
                                listaCodigoNegocios.Add(codigo);
                                aux2 = true;
                                
                            }
                        }
                        while (aux2 is false);

                        Console.WriteLine("El codigo de este negocio es: " + codigo);

                        Console.WriteLine("Ingrese el nombre del negocio");
                        string respNombreNegocio = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("¿Que impacto social o económico genera?");
                        string respImpacto = Convert.ToString(Console.ReadLine() );

                        Console.WriteLine("¿Cuantos departamentos abarca el negocio?");
                        int respCantidadDepartamentos = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" ");

                        //Se crea una copia de la lista para que no afecte a la lista principal

                        List<string> copiaLista = new List<string>(departamentos);
                        for (int cantDepartamentos = 1; cantDepartamentos <= respCantidadDepartamentos; cantDepartamentos++)
                        {
                            for (int contador = 0; contador < copiaLista.Count; contador++)
                            {

                                Console.WriteLine((contador) + ". " + copiaLista[contador]);

                            }
                            Console.WriteLine("Ingrese el numero del departamento");
                            int respNumeroDépartamento = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Agregaste " + copiaLista[respNumeroDépartamento]);
                            copiaLista.RemoveAt(respNumeroDépartamento);
                            

                        }
                        Console.WriteLine(" ");

                        Console.WriteLine("Ingrese el valor de inversion");
                        double respValorInversion = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Total de ingresos a generar en los primeros 3 años");
                        double respTotalIngresos = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Ingrese la cantidad de integrantes del negocio");
                        int respCantidadIntegrantes = Convert.ToInt32(Console.ReadLine());

                        for(int cantIntegrantes = 1; cantIntegrantes <= respCantidadIntegrantes; cantIntegrantes++)
                        {
                            Console.WriteLine("Ingrese el id del integrate #" + cantIntegrantes);
                            string respIdIntegrante = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("ingrese el nombre del integrante #" + cantIntegrantes);
                            string respNombreIntegrante = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Ingrese los apellidos del integrante #" + cantIntegrantes);
                            string respApellidosIntegrante = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Ingrese el rol dentro del emprendimiento del integrante #" + cantIntegrantes);
                            string respRolIntegrante = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Ingrese el email del integrante #" + cantIntegrantes);
                            string respEmailIntegrante = Convert.ToString(Console.ReadLine());


                            IntegrantesNegocio integrante = new IntegrantesNegocio(
                                respIdIntegrante, 
                                respNombreIntegrante,
                                respApellidosIntegrante,
                                respRolIntegrante, 
                                respEmailIntegrante);

                            listaIntegrantesNegocios.Add(integrante);


                            Negocios negocio = new Negocios(
                                codigo,
                                respValorInversion,
                                respTotalIngresos,
                                respNombreNegocio,
                                respImpacto
                                );

                            listaNegocios.Add(negocio);

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("--------------------------------------------------------------------------------------");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");


                            
                        }
                        Console.WriteLine("Herramientas 4RI que utiliza");

                        



                        


                    }


                }
                else
                {
                    Console.WriteLine("ERROR: Ingresa un numero valido\n");
                }


            } while (aux is false);
            Console.WriteLine(listaIntegrantesNegocios[0]);
            Console.WriteLine(listaIntegrantesNegocios[1]);
            Console.WriteLine(listaIntegrantesNegocios.Count);
            listaIntegrantesNegocios.ToList().ForEach(Console.WriteLine);
        }
    }
}
