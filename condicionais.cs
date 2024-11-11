using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite um número ");
            n1 = Convert.ToInt32(Console.ReadLine());   

            Console.WriteLine("Digite outro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());       

            if (n1 > n2)
            {
                Console.WriteLine("10 não é mairo que 20 ");
            }
            else
            {
                //preciso corrigir
                Console.WriteLine("Número ",n1," é maior que ", n2);

            }
            Console.ReadKey();  
        }
    }
}
