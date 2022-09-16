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
                    double maxIngresos = 0;
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
                        List<string> listaHerramientas4RI = new List<string>();
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
                            
                            bool aux3 = false;
                            do
                            {
                                //la inversion no puede ser 0 porque al hacer la rentabilidad va a dar un error
                                Console.WriteLine("Ingrese el valor de inversion");
                                Console.WriteLine(" ");
                                respValorInversion = Convert.ToDouble(Console.ReadLine());
                                if (respValorInversion == 0)
                                {
                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: La inversion no puede ser 0\n");
                                    Console.ResetColor();
                                    
                                }
                                else
                                {
                                    aux3 = true;
                                }


                            }while(aux3 is false);
                            
                            
                            
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
                                Console.WriteLine("¿El negocio tiene inteligencia artificial?");
                                Console.ResetColor();
                                Console.WriteLine(" ");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                Console.WriteLine(" ");
                                int respInteligenciaART = Convert.ToInt32(Console.ReadLine());
                                if (respInteligenciaART == 1)
                                {
                                    listaHerramientas4RI.Add("Inteligencia artificial");
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
                                Console.WriteLine("¿El negocio tiene biometria?");
                                Console.ResetColor();
                                Console.WriteLine(" ");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                Console.WriteLine(" ");
                                int respBiometria = Convert.ToInt32(Console.ReadLine());
                                if (respBiometria == 1)
                                {
                                    listaHerramientas4RI.Add("Biometria");
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
                                Console.WriteLine("¿El negocio tiene cloud computing?");
                                Console.ResetColor();
                                Console.WriteLine(" ");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                Console.WriteLine(" ");
                                int respCloudcomputing = Convert.ToInt32(Console.ReadLine());
                                if (respCloudcomputing == 1)
                                {
                                    listaHerramientas4RI.Add("Cloud computing");
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
                                Console.WriteLine("¿El negocio integra internet de las cosas?");
                                Console.ResetColor();
                                Console.WriteLine(" ");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                Console.WriteLine(" ");
                                int respIot = Convert.ToInt32(Console.ReadLine());
                                if (respIot == 1)
                                {
                                    listaHerramientas4RI.Add("Internet de las cosas");
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
                        negocio.Lista4RI = listaHerramientas4RI;
                        negocio.Rentabilidad = ((negocio.TotalIngresos_3Annos / negocio.ValorInversion)*100);
                        negocio.ContDep = respCantidadDepartamentos;
                        negocio.NegocioDepartamentos = departamentosParaElObjeto;
                        negocio.Integrantes = listaIntegrantesNegocios;
                        listaNegocios.Add(negocio);
                        
                    }

                    int indiceLista = 0;

                    for(int max = 0; max == listaNegocios.Count; max++)
                    {
                        if (listaNegocios[max].TotalIngresos_3Annos >= maxIngresos && listaNegocios[max].ContDep >= maxDepartamentos)
                        {
                            maxIngresos = listaNegocios[max].TotalIngresos_3Annos;
                            maxDepartamentos = listaNegocios[max].ContDep;
                            indiceLista = max;

                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(separador);
                    Console.ResetColor();

                    /*Mostrar toda la información de la idea de negocio que impacte más departamentos
                    y tenga el mayor total de ingresos en los primeros 3 años*/
                    Console.WriteLine("Idea de negocio que mas departamentos y ingresos tiene");
                    Console.WriteLine("Codigo del negocio: " + listaNegocios[indiceLista].Codigo);
                    Console.WriteLine("Nombre de la idea de negocio: " + listaNegocios[indiceLista].NombreIdeaNegocio);
                    Console.WriteLine("Impacto: " + listaNegocios[indiceLista].ImpactoSocial_Economico);
                    Console.WriteLine("departamento/s: ");
                    foreach (var indexNegocios in listaNegocios[indiceLista].NegocioDepartamentos)
                    {
                        Console.WriteLine("- " + indexNegocios);
                    }
                    Console.WriteLine("Valor inversion: " + listaNegocios[indiceLista].ValorInversion);
                    Console.WriteLine("Total de ingresos a los primeros 3 años: " + listaNegocios[indiceLista].TotalIngresos_3Annos);
                    foreach (var index4RI in listaNegocios[indiceLista].Lista4RI)
                    {
                        Console.WriteLine("Herramientas 4RI: " + index4RI);
                    }
                    
                    Console.WriteLine("");
                    
                    // Mostrar el nombre de las 3 ideas de negocio que generen más rentabilidad
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(separador);
                    Console.ResetColor();
                    Console.WriteLine("Las 3 ideas de negocio con mas rentabilidad");
                    
                    string nombreRent1 = " ";
                    string nombreRent2 = " ";
                    string nombreRent3 = " ";
                    double rent1 = listaNegocios[0].Rentabilidad;
                    double rent2 = listaNegocios[0].Rentabilidad;
                    double rent3 = listaNegocios[0].Rentabilidad;
                    
                 

                    for (int indexRentabilidad = 0; indexRentabilidad < listaNegocios.Count; indexRentabilidad++)
			        {
                       
                        if (listaNegocios[indexRentabilidad].Rentabilidad >= rent2 && listaNegocios[indexRentabilidad].Rentabilidad >= rent3)
                        {
                            
                            rent1 = listaNegocios[indexRentabilidad].Rentabilidad;
                            nombreRent1 = listaNegocios[indexRentabilidad].NombreIdeaNegocio;
                            
          

                        }
                        else if(listaNegocios[indexRentabilidad].Rentabilidad >= rent3)
                        {
                            
                            rent2 = listaNegocios[indexRentabilidad].Rentabilidad;
                            nombreRent2 = listaNegocios[indexRentabilidad].NombreIdeaNegocio;
                            
                            
                        }
                        else
                        {
                            
                            rent3 = listaNegocios[indexRentabilidad].Rentabilidad;
                            nombreRent3 = listaNegocios[indexRentabilidad].NombreIdeaNegocio;
                        }
			        }

                    Console.WriteLine("1ro:" + nombreRent1);
                    Console.WriteLine("2do:" + nombreRent2);
                    Console.WriteLine("3ro:" + nombreRent3);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(separador);
                    Console.ResetColor();

                    //Nombre de los emprendimientos impacten más de 3 departamentos
                    Console.WriteLine("Nombres de las ideas de negocio con mas de 3 departamentos");
                    List<string> masDepartamentos = new List<string>();
                    for(int indexDept = 0; indexDept < listaNegocios.Count; indexDept++)
                    {
                        if(listaNegocios[indexDept].ContDep > 3)
                        {
                            masDepartamentos.Add(listaNegocios[indexDept].NombreIdeaNegocio);
                        }
                    }

                    foreach (var indexMasDepartamentos in masDepartamentos)
                    {
                        Console.WriteLine("- " + indexMasDepartamentos);
                    }


                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(separador);
                    Console.ResetColor();

                    
                    //Suma total de la inversión que se debe hacer en todas las ideas de negocio
                    Console.WriteLine("La suma total de la inversión que se debe hacer en todas las ideas de negocio es: " + acumInversion);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(separador);
                    Console.ResetColor();

                    //Suma total de ingresos de todas las ideas de negocio
                    Console.WriteLine("La suma total de ingresos de todas las ideas de negocio es: " + acumIngresos);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(separador);
                    Console.ResetColor();

                    //Nombre de la idea de negocio con los integrantes del equipo que tenga la mayor cantidad de herramientas 4RI en su emprendimiento
                    int mayor = 0;
                    int otroIndexAyuda = 0;

                    for(int otroIndexMas = 0; otroIndexMas < listaNegocios.Count;otroIndexMas++)
                    {
                        if(listaNegocios[otroIndexMas].Lista4RI.Count > mayor)
                        {
                            mayor = listaNegocios[otroIndexMas].Lista4RI.Count;
                            otroIndexAyuda = otroIndexMas;
                                
                        }
                        
                    }
                    Console.WriteLine("El mayor emprendimiento con 4RI es: " + listaNegocios[otroIndexAyuda].NombreIdeaNegocio);
                    Console.WriteLine("Sus integrantes son:" );
                    for(int quieroDormir = 0;quieroDormir < listaNegocios[otroIndexAyuda].Integrantes.Count; quieroDormir++)
                    {
                        Console.WriteLine("- " + listaNegocios[otroIndexAyuda].Integrantes[quieroDormir].Nombre + listaNegocios[otroIndexAyuda].Integrantes[quieroDormir].Apellidos);
                    }

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(separador);
                    Console.ResetColor();

                    //Cantidad de ideas de negocio que tienen Inteligencia Artificia
                    Console.WriteLine("El total de ideas que utilizan inteligencia artificial es: " + contadorIA);


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
