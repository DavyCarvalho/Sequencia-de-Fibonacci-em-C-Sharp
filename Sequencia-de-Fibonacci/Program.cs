using System;

namespace Sequencia_de_Fibonacci
{
    static class Program
    {
        static void Main(string[] args)
        {
            var x = 1;
            var y = 0; 
            var z = 0;

            var inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                y = x;
                x = z;
            }
            Console.ReadLine();
        }
    }
}
