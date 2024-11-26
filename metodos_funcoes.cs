using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_e_funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma operação");
            Console.WriteLine(" 1 - soma \n 2 - subtração\n 3 - multiplicar\n 4 - divisão\n ");

            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            int n2 = int.Parse(Console.ReadLine());

            //switch irá analisar a opção
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("soma: " + somar(n1, n2));

                    break;

                case 2:
                    Console.WriteLine("subtrair: "+ subtrair(n1, n2));
                    break;

                case 3:
                    Console.WriteLine("multiplicar: "+ mult(n1,n2));
                    break;

                case 4:
                    Console.WriteLine("Dividir: " + dividir(n1,n2));
                    break;

                default:
                    Console.WriteLine("Invalido");
                    break;

            }

            Console.ReadKey();
        }
        static int somar(int a, int b)
        {
            return a + b;
        }
        static int subtrair(int a, int b)
        {
            return a - b;
        }
        static int mult(int a, int b)
        {
            return a * b;
        }
        static double dividir(int a, int b)
        {
            if (b != 0)
            {
                return (double)a / b;
            }
            else
            {
                Console.WriteLine("Não é possível dividir por 0");
                return 0;
            }
        }
    }
}

