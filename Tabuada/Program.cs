using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine("Exibir tabuada de 1 até que numero?");

            if (!int.TryParse(Console.ReadLine(), out numero1))
            {
                Console.Clear();
                Console.WriteLine("Insira apenas números inteiros!!");
                Console.WriteLine("\n\nExibir tabuada de até que numero?");
                numero1 = int.Parse(Console.ReadLine());
            }
            else
            {

                Console.WriteLine("\n");

                for (int i = 1; i <= numero1; i++)
                {
                    Console.WriteLine(" Tabuada do " + i);
                    for (int c = 1; c <= 10; c++)
                    {
                        Console.WriteLine(" " + i + "x" + c + "=" + i * c);
                    }

                    Console.WriteLine("\n");
                }
                Console.Read();
            }
        }
    }
}