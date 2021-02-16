using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проект
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("как вас зовут?");
            a = Console.ReadLine();
            Console.WriteLine($"Привет {a}");
            Console.ReadKey();
        }
    }
}
