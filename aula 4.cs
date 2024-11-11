using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua idade? ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade <= 18)
            {
                Console.WriteLine("Proibido menores!!");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("~Você esta velho");
            }
            else if (idade >= 30)
            {
                Console.WriteLine("Eae vovô");
            }
            else
            {
                Console.WriteLine("Você é kid ");
            }
            Console.ReadKey();  
        }
    }
}
