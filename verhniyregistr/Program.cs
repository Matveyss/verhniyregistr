using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verhniyregistr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово нижнего регистра:");
            string a = Console.ReadLine();
            a = a.ToUpper();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
