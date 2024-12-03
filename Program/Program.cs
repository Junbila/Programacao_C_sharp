using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            /*  Maior >
                Menor <
                Igual ==
                >= Maior ou Igual
                <= Menor ou Igual
                != Diferente
            */

            Console.WriteLine("19 > 22 " + (19 > 22));
            Console.WriteLine("19 < 22 " + (19 < 22));
            Console.WriteLine("19 == 22 " + (19 == 22));
            Console.WriteLine("19 >= 22 " + (19 >= 22));
            Console.WriteLine("19 <= 22 " + (19 <= 22));
            Console.WriteLine("19 != 22 " + (19 != 22));
            Console.ReadKey();  
        }
    }
}
