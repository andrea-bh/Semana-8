using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a. Sumatoria de un número");
            Console.WriteLine("b. Tablas de multiplicar");
            Console.WriteLine("c. Número perfecto");
            Console.Write("Ingrese una opción: ");
            char opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("\n" + "Sumatoria");
                    Console.Write("Ingrese un número: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    int resultado = 0;

                    do
                    {
                        resultado = resultado + n;
                        n--;
                    } while (n > 0);
                    Console.WriteLine("\n" + "Sumatoria = " + resultado);
                    break;
                case 'b':
                    Console.WriteLine("\n" + "Tablas de Multiplicar");

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write(i + ": ");
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.Write((i * j) + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 'c':
                    Console.WriteLine("Ingrese un número: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    string resultado2 = "";
                    int valuacion = 0;

                    for (int i = num - 1; i >= 0; i--)
                    {
                        if (num % i == 0) ;
                        {
                            resultado2 = resultado2 + "" + Convert.ToString(i) + "+";
                            valuacion = valuacion + i;
                        }

                    }
                    if (valuacion == num)
                        Console.WriteLine(resultado2);
                    else
                        Console.WriteLine("No es un número perfecto");
                    break;

            }
            Console.ReadKey();

            // TAREA SEMANA 8

            Console.WriteLine("Ingrese un número");
            int dec = Convert.ToInt32(Console.ReadLine());
            string res3 = " ";
            while (dec > 0)
            {
                if (dec% 2 == 0)
                {
                    res3 = "0" + res3;
                    dec = dec / 2;

                }
                else
                {
                    dec = dec / 2;
                    res3= "1" + res3;
                
                }
            }
            Console.WriteLine(res3);



            // TAREA SEMANA 8 SEGUNDA PARTE

            Console.WriteLine(" A hexadecimal");
            Console.WriteLine("Ingrese un número ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num, 16));
            Console.ReadKey();
        }
    }
}
