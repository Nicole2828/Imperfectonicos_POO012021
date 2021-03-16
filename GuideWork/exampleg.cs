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

            Console.WriteLine($"Multiplying {a} * {b} equals {MultiplyNumbers(a,b)} ");

        }
        
        // 1) Task: Hacer la primera modificación de la funcion AddNumbers
        // (convertirlo en resta) 
        // 2) Task: Hacer la segunda modificación de la funcion AddNumbers
        // (convertirlo en multiplicación)
        public static int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }
    }
}

 
