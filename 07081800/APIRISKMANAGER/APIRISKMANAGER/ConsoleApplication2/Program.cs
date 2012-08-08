using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorFormatado = string.Format("Meu Nome{0}", "Jorge");
            Console.WriteLine(valorFormatado);
            Console.ReadKey();
        }
    }
}
