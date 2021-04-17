using System;

namespace Automovil
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            byte bandera = 0;
            string cadena;

            void titulo()
            {
                Console.WriteLine("");
                Console.WriteLine("   ---------------------------------------------------");
                Console.WriteLine("   |  Automóvil: conduciendo y cargando combustible  |");
                Console.WriteLine("   ---------------------------------------------------");
                Console.WriteLine("");
            }

            titulo();

            do
            {
                Console.WriteLine("Desea conducir (1), cargar el tanque (2) o salir del programa (0)");
                do
                {
                    if (bandera != 0 && bandera != 1 && bandera != 2)
                    {
                        Console.WriteLine("Ingrese un código correcto: conducir (1), cargar el tanque (2) o salir del programa (0)");
                    }
                    try
                    {
                        bandera = byte.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        bandera = 3;
                    }
                    Console.Clear();
                    titulo();
                } while (bandera != 0 && bandera != 1 && bandera != 2);

                if (bandera == 1)
                {
                    Console.WriteLine("Ingresar los km que quiere recorrer");
                    do  // bucle para tomar un valor correcto en kilometros
                    {
                        if (auto.Kilometros <= 0)
                        {
                            Console.WriteLine("Ingresar los km que quiere recorrer, ingrese un valor correcto");
                        }
                        try
                        {
                            cadena = Console.ReadLine();
                            auto.Kilometros = float.Parse(cadena.Replace(".", ","));
                        }
                        catch
                        {
                            auto.Kilometros = -1;
                        }
                        Console.Clear();
                        titulo();
                    } while (auto.Kilometros <= 0);
                    Console.WriteLine(auto.Conducir());  // el método se ejecuta cuando hay un valor correcto en kilometros
                    Console.WriteLine("");
                }

                if (bandera == 2)
                {
                    Console.WriteLine("Ingresar los litros que quiere cargar");
                    do  // bucle para tomar un valor correcto en combustible
                    {
                        if (auto.Combustible <= 0)
                        {
                            Console.WriteLine("Ingresar los litro que quiere cargar, ingrese un valor correcto");
                        }
                        try
                        {
                            cadena = Console.ReadLine();
                            auto.Combustible = float.Parse(cadena.Replace(".", ","));
                        }
                        catch
                        {
                            auto.Combustible = -1;
                        }
                        Console.Clear();
                        titulo();
                    } while (auto.Combustible <= 0);
                    Console.WriteLine(auto.Cargar());  // el método se ejecuta cuando hay un valor correcto en combustible
                    Console.WriteLine("");
                }
            } while (bandera != 0);
        }
    }
}