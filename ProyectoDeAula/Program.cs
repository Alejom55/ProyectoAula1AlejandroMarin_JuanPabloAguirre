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
                        }
                        



                        


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








