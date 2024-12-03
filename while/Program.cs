using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num;

            Console.WriteLine("*****Tabuada*****");
            Console.WriteLine("Digite o Número desejado");
            num = int .Parse(Console.ReadLine());

            while (i <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num);
                i++;
            }
            
            Console.ReadKey();  
        }
    }
}
