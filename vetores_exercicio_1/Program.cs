using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores_exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cores = {"vermelho", "Verde", "Azul", "Roxo"};

            for (int i = 0; i < cores.Length; i++)
            {
                Console.WriteLine("Cor: " + (i+1) + " " + cores[i]);
            }
            /* comando paraq "for"
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            int[] numeros = new int[5];
            double n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0; 

            Console.Write("Digite numero 1: ");
            numeros[0] = int.Parse(Console.ReadLine());

            Console.Write("Digite numero 2: ");
            numeros[0] = int.Parse(Console.ReadLine());
            
            Console.Write("Digite numero 3: ");
            numeros[0] = int.Parse(Console.ReadLine());

            Console.Write("Digite numero 4: ");
            numeros[0] = int.Parse(Console.ReadLine());

            Console.Write("Digite numero 5: ");
            numeros[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Os numeros foram: ");

            int maior = numeros[0];
            if (numeros[1] > numeros[0]) { maior = numeros[1];
            (numeros[2] > maior) { maior = numeros[2]};
            (numeros[3]);
            (numeros[4]);
            
            if (numeros[0] >= 0)
            {
                Console.WriteLine("O maior numero é: " + numeros );
                numeros[0] = Convert.ToInt32(numeros[0]);
            }
            */
            Console.ReadKey();  
        }
    }
}
