using System;

namespace SampleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] != "null")
                Console.WriteLine($"Hello {args[0]}!");
            else
                Console.WriteLine("Testing null start");
            
            Console.Read();
        }
    }
}
