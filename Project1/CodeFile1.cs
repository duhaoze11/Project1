using System;

namespace a_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("The input are not numbers");
            }
            Console.WriteLine("a+b="+( a + b));
            Console.Read();
        }
    }
}
