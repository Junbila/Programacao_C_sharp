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
            num = int .Parse(Console.ReadLine());//parse 

            while (i <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i); // {} os numeros nas chaves são para demonstrar as funções
                i++;//para não ficar infinito
            }
            
            Console.ReadKey();  
        }
    }
}
