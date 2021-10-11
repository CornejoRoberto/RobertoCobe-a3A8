using System;

namespace RobertoCobeña3A8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Introduzca su número:");
            num1 = int.Parse(Console.ReadLine());            
            for (int i = 1; i <= num1; i++)
            {
                    Console.Write(" *");
                    Console.WriteLine(i);               
                }               
            for (int f = 2; f <= num1; f = f + 2)
            {
                Console.Write("\t");
                Console.Write(" *");
                Console.WriteLine(f);
                
            }
            for (int k = 3; k <= num1; k = k + 3)
            {
                Console.Write("\t");
                Console.Write("\t");
                Console.Write(" *");
                Console.WriteLine(k);
            }
        }
    }
}
