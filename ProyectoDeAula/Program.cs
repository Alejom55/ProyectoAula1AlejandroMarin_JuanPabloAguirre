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
                "Cauca", "Cesar", "Chocó", "Córdoba", "Cundinamarca",
                "Guainía", "Guaviare", "Huila", "La Guajira", "Magdalena",
                "Meta", "Nariño", "Norte de Santander", "Putumayo", "Quindío",
                "Risaralda", "San Andrés y Providencia", "Santander", "Sucre", "Tolima",
                "Valle del Cauca", "Vaupés", "Vichada"
            };

            //Ayuda hace que no se cierre automaticamente la consola
            void ayuda()
            {
                string ayuda = Convert.ToString(Console.ReadLine());
            }
            

            string separador = new string('*', 45);
            Console.WriteLine(separador);
            Console.WriteLine("BIENVENIDO A EMPRENDIMIENTOS CON HERRAMIENTAS \n DE LA CUARTA REVOLUCIÓN INDUSTRIAL (4RI)");
            Console.WriteLine(separador);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¿Que desea hacer?");
            Console.ResetColor();
            bool aux = false;
            do
            {
                
                Console.WriteLine("1. Agregar Negocio");
                int respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta == 1)
                {
                    int maxDepartamentos = 0;
                    int maxIngresos = 0;
                    aux = true;
                    int contadorRI = 0;
                    int contadorIA = 0;
                    Double acumIngresos = 0;
                    Double acumInversion = 0;
                    Console.WriteLine(separador);
                    Console.WriteLine("¿Cuantos negocios desea agregar?");
                    int respCantidadNegocios = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");

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

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("El codigo de este negocio es: " + codigo);
                        Console.ResetColor();
                        Console.WriteLine(" ");

                        Console.WriteLine("Ingrese el nombre del negocio");
                        Console.WriteLine(" ");
                        string respNombreNegocio = Convert.ToString(Console.ReadLine());
                        Console.WriteLine(" ");

                        Console.WriteLine("¿Que impacto social o económico genera?");
                        Console.WriteLine(" ");
                        string respImpacto = Convert.ToString(Console.ReadLine() );
                        Console.WriteLine(" ");

                        Console.WriteLine("¿Cuantos departamentos abarca el negocio?");
                        Console.WriteLine(" ");
                        int respCantidadDepartamentos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Se crea una copia de la lista para que no afecte a la lista principal

                        List<string> copiaLista = new List<string>(departamentos);
                        List<string> departamentosParaElObjeto = new List<string>();
                        for (int cantDepartamentos = 1; cantDepartamentos <= respCantidadDepartamentos; cantDepartamentos++)
                        {
                            for (int contador = 0; contador < copiaLista.Count; contador++)
                            {

                                Console.WriteLine((contador) + ". " + copiaLista[contador]);

                            }
                            Console.WriteLine("Ingrese el numero del departamento");
                            Console.WriteLine(" ");
                            int respNumeroDépartamento = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Agregaste " + copiaLista[respNumeroDépartamento]);
                            Console.ResetColor();
                            Console.WriteLine(" ");
                            departamentosParaElObjeto.Add(copiaLista[respNumeroDépartamento]);
                            copiaLista.RemoveAt(respNumeroDépartamento);
                            

                        }
                        Console.WriteLine(" ");
                        bool modificar = true;
                        double respValorInversion;
                        double respTotalIngresos;
                        do
                        {
                            Console.WriteLine("Ingrese el valor de inversion");
                            Console.WriteLine(" ");
                            respValorInversion = Convert.ToDouble(Console.ReadLine());
                            acumInversion = acumInversion + respValorInversion;
                            Console.WriteLine(" ");

                            Console.WriteLine("Total de ingresos a generar en los primeros 3 años");
                            Console.WriteLine(" ");
                            respTotalIngresos = Convert.ToDouble(Console.ReadLine());
                            acumIngresos = acumIngresos + respTotalIngresos;
                            Console.WriteLine(" ");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("¿Desea modificar los valores ingresados de inversion e ingresos?");
                            Console.ResetColor();
                            Console.WriteLine(" ");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("2. No");
                            Console.WriteLine(" ");
                            int respModificar = Convert.ToInt32(Console.ReadLine());
                            if (respModificar == 1)
                            {
                                modificar = true;
                                acumIngresos = 0;
                                acumInversion = 0;
                            }
                            else if (respModificar == 2)
                            {
                                modificar = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("ERROR: Ingresa un numero valido\n");
                                Console.ResetColor();
                            }
                        } while (modificar == true);

                        Console.WriteLine("herramientas 4RI que utiliza");
                        bool RI = false;

                        do
                        {
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("¿Su negocio tiene inteligencia artificial?");
                                Console.ResetColor();
                                Console.WriteLine(" ");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                Console.WriteLine(" ");
                                int respInteligenciaART = Convert.ToInt32(Console.ReadLine());
                                if (respInteligenciaART == 1)
                                {
                                    RI = true;
                                    contadorIA++;
                                    contadorRI++;
                                }
                                else if (respInteligenciaART == 2)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: Ingresa un numero valido\n");
                                    Console.ResetColor();
                                }
                            } while (RI == false);
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("¿Su negocio tiene Biometria?");
                                Console.ResetColor();
                                Console.WriteLine(" ");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                Console.WriteLine(" ");
                                int respBiometria = Convert.ToInt32(Console.ReadLine());
                                if (respBiometria == 1)
                                {
                                    RI = true;
                                    contadorRI++;
                                }
                                else if (respBiometria == 2)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: Ingresa un numero valido\n");
                                    Console.ResetColor();
                                }
                            } while (RI == false);
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("¿Su negocio tiene Cloud Computing?");
                                Console.ResetColor();
                                Console.WriteLine(" ");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                Console.WriteLine(" ");
                                int respCloudcomputing = Convert.ToInt32(Console.ReadLine());
                                if (respCloudcomputing == 1)
                                {
                                    RI = true;
                                    contadorRI++;
                                }
                                else if (respCloudcomputing == 2)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: Ingresa un numero valido\n");
                                    Console.ResetColor();

                                }
                            } while (RI == false);
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("¿Su negocio integra Internet de las cosas?");
                                Console.ResetColor();
                                Console.WriteLine(" ");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                Console.WriteLine(" ");
                                int respIot = Convert.ToInt32(Console.ReadLine());
                                if (respIot == 1)
                                {
                                    RI = true;
                                    contadorRI++;
                                }
                                else if (respIot == 2)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: Ingresa un numero valido\n");
                                    Console.ResetColor();
                                }
                            } while (RI == false);

                        }
                        while (RI is false);

                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese la cantidad de integrantes del negocio");
                        Console.WriteLine(" ");
                        int respCantidadIntegrantes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        for(int cantIntegrantes = 1; cantIntegrantes <= respCantidadIntegrantes; cantIntegrantes++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Ingrese el id del integrate #" + cantIntegrantes);
                            Console.WriteLine(" ");
                            string respIdIntegrante = Convert.ToString(Console.ReadLine());
                            Console.WriteLine(" ");

                            Console.WriteLine("Ingrese el nombre del integrante #" + cantIntegrantes);
                            Console.WriteLine(" ");
                            string respNombreIntegrante = Convert.ToString(Console.ReadLine());
                            Console.WriteLine(" ");

                            Console.WriteLine("Ingrese los apellidos del integrante #" + cantIntegrantes);
                            Console.WriteLine(" ");
                            string respApellidosIntegrante = Convert.ToString(Console.ReadLine());
                            Console.WriteLine(" ");

                            Console.WriteLine("Ingrese el rol dentro del emprendimiento del integrante #" + cantIntegrantes);
                            Console.WriteLine(" ");
                            string respRolIntegrante = Convert.ToString(Console.ReadLine());
                            Console.WriteLine(" ");

                            Console.WriteLine("Ingrese el email del integrante #" + cantIntegrantes);
                            Console.WriteLine(" ");
                            string respEmailIntegrante = Convert.ToString(Console.ReadLine());
                            Console.WriteLine(" ");

                            
                            IntegrantesNegocio integrante = new IntegrantesNegocio(
                                respIdIntegrante, 
                                respNombreIntegrante,
                                respApellidosIntegrante,
                                respRolIntegrante, 
                                respEmailIntegrante);

                            listaIntegrantesNegocios.Add(integrante);

                            Console.WriteLine(separador);
                            
                        }
                        Negocios negocio = new Negocios(
                            codigo,
                            respValorInversion,
                            respTotalIngresos,
                            respNombreNegocio,
                            respImpacto
                            );
                        
                        negocio.ContDep = respCantidadDepartamentos;
                        negocio.NegocioDepartamentos = departamentosParaElObjeto;
                        listaNegocios.Add(negocio);
                        
                        negocio.Integrantes = listaIntegrantesNegocios;
                        int aux4 = 0;
                        foreach (var t in negocio.NegocioDepartamentos)
                        {
                            
                            Console.WriteLine("departamento: " + t);
                            
                        }
                        Console.WriteLine("Cantidad departamentos: " + negocio.ContDep);

                        void Hola()
                        {
                            Console.WriteLine("Hola");
                        }

                        
                        
                        

                    }
                    /*for(int i = 0; i <= listaNegocios.Count; i++)
                    {
                        if (listaNegocios[i].TotalIngresos_3Annos >= maxIngresos  )
                    }*/

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(separador);
                    Console.ResetColor();

                    //Cantidad de ideas de negocio que tienen Inteligencia Artificia
                    Console.WriteLine("El total de ideas que utilizan inteligencia artificial es: " + contadorIA);
                    //Suma total de la inversión que se debe hacer en todas las ideas de negocio
                    Console.WriteLine("La suma total de la inversión que se debe hacer en todas las ideas de negocio es: " + acumInversion);

                    //Suma total de ingresos de todas las ideas de negocio
                    Console.WriteLine("La suma total de ingresos de todas las ideas de negocio es: " + acumIngresos);

                    Console.WriteLine(listaNegocios[0].NombreIdeaNegocio);
                    ayuda();
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Ingresa un numero valido\n");
                    Console.ResetColor();
                }


            } while (aux is false);
        }
    }
}
