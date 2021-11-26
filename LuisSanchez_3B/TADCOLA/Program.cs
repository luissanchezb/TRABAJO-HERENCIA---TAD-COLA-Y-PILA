using System;
using System.Collections.Generic;

namespace TADCOLA
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacion = 0;
            //


            //Objetos de Supermercado clase A

            SupermercadoClaseA ElDorado = new SupermercadoClaseA();
            ElDorado.Nombre = " Supermercado El Dorado";
            ElDorado.Ciudad = "Daule";
            ElDorado.Añodecreacion = 2000;
            ElDorado.Premios = "Premio Control de Calidad 5 Estrellas";
            ElDorado.ReconocimientoInternacional = "Mejor Supermercado del Mundo 2020";

            // Objetos de Supermercado clase B

            SupermercadoClaseB Aki = new SupermercadoClaseB();
            Aki.Nombre = "Aki";
            Aki.Ciudad = "Manta";
            Aki.Añodecreacion = 1990;
            Aki.Tipo = "Extension Grande";
            Aki.ReconocimientoNacional = "Mejor Supermercado  Ecuatoriano 2021";

            //Cola de Supermercados 

            Queue<Supermercado> colasupermercados = new Queue<Supermercado>();
            colasupermercados.Enqueue(ElDorado);
            colasupermercados.Enqueue(Aki);


            // Menu de la Cola

            do
            {
                Console.Clear();
                Console.WriteLine("1) Encolar");
                Console.WriteLine("2) Desencolar");
                Console.WriteLine("3) Imprimir Cola");
                Console.WriteLine();
                Console.WriteLine("Escoja una opcion: ");
                operacion = int.Parse(Console.ReadLine());
                if (operacion < 1 || operacion > 3)
                {
                    Console.WriteLine("Ingrese la opcion correcta");
                    Console.WriteLine();
                    Console.WriteLine("Presiona una tecla para volver a elegir una opcion");
                    Console.ReadKey();
                }
                switch (operacion)
                {
                    case 1:
                        {
                            SupermercadoClaseA NuevoSupermercadoA = new SupermercadoClaseA();
                            SupermercadoClaseB NuevoSupermercadoB = new SupermercadoClaseB();
                            Console.Clear();
                            Console.WriteLine("Encolar Supermercado A o Supermercado B?");
                            Console.WriteLine("1) Supermercado A");
                            Console.WriteLine("2) Supermercado B");
                            Console.WriteLine("Opcion escogida:  ");
                            int operacion2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (operacion2 == 1)
                            {
                                Console.WriteLine("Encolar Supermercado A");
                                Console.WriteLine("Nombre del Supermercado:  ");
                                NuevoSupermercadoA.Nombre = Console.ReadLine();
                                Console.WriteLine("Ciudad del Supermercado: ");
                                NuevoSupermercadoA.Ciudad = Console.ReadLine();
                                Console.WriteLine("Año de creacion:): ");
                                NuevoSupermercadoA.Añodecreacion = int.Parse(Console.ReadLine());
                                Console.WriteLine("Premios obtenidos: ");
                                NuevoSupermercadoA.Premios = Console.ReadLine();
                                Console.WriteLine("Reconocimiento Internacional ");
                                NuevoSupermercadoA.ReconocimientoInternacional = Console.ReadLine();
                                colasupermercados.Enqueue(NuevoSupermercadoA);

                            }
                            else
                            {
                                if (operacion2 == 2)
                                {

                                    Console.WriteLine("Encolar Supermercado B");
                                    Console.WriteLine("Nombre del Supermercado: ");
                                    NuevoSupermercadoB.Nombre = Console.ReadLine();
                                    Console.WriteLine("Ciudad del Supermercado: ");
                                    NuevoSupermercadoB.Ciudad = Console.ReadLine();
                                    Console.WriteLine("Año de creacion: ");
                                    NuevoSupermercadoB.Añodecreacion = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Tipo de Supermercado ");
                                    NuevoSupermercadoB.Tipo = Console.ReadLine();
                                    Console.WriteLine("Reconocimiento Nacional: ");
                                    NuevoSupermercadoB.ReconocimientoNacional = Console.ReadLine();
                                    colasupermercados.Enqueue(NuevoSupermercadoB);

                                }
                                else
                                {
                                    Console.ReadKey();
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Presione una tecla para regresar al menu");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();

                            //Desencolar la Cola

                            colasupermercados.Dequeue();
                            Console.WriteLine("Se ha desencolado un objeto de la cola\n");
                            Console.WriteLine();
                            Console.WriteLine("Presione una tecla para regresar al menu");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();

                            //Imprimir la Cola

                            foreach (Supermercado supermercado in colasupermercados)
                            {
                                supermercado.mostrar();
                                supermercado.Propiedades();
                                Console.WriteLine();
                            }
                            Console.WriteLine("Presione una tecla para regresar al menu");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (operacion != 4);
        }
    }
}
