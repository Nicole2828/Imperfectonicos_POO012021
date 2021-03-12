using System;
// Primer paso crear el programa del ejemplo guiadado 
namespace exampleg
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine( "Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {a} + {b} equals {AddNumbers(a,b)} ");

        }
        
        // 1)Tasks: Hacer la primera modificación de la funcion AddNumbers
        // (convertirlo en resta) /
        public static int AddNumbers(int a, int b)
        {
            return a - b;
        }
    }
}

//2) Tasks: Hacer la segunda modificación de la funcion AddNumbers
// (convertirlo en multiplicación) 
