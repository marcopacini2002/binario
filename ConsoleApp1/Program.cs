using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a);
            Console.WriteLine(a + 3);
            int b = int.MinValue;
            Console.WriteLine(b);


            int n ;
            Console.WriteLine("inserisci un numeretto");
            n=Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine(binary);
            Console.ReadLine();
            

        }
    }
}
