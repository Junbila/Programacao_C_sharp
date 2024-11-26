using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirMenu();

            Console.WriteLine("\n////Wellcome sir!!!////");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    int quantidade = qtd();
                    double valor = calcularhamburguer(quantidade);

                    Console.WriteLine("Total: " + valor + "$");
                    break;
            }
            Console.ReadKey();
        }

        static void ExibirMenu()
        {
            Console.WriteLine("//// Cluckin Bell ////\n");
            Console.WriteLine("1 - Hamburguer $ 25,00 ");
            Console.WriteLine("2 - Extra Dip $ 7,00 ");
            Console.WriteLine("3 - Two Number Nines $ 9,00 ");
            Console.WriteLine("4 - Number Nine Large $ 16,00 ");
        }
        static int qtd()
        {
            Console.WriteLine("Digite a quantidade");
            return int.Parse(Console.ReadLine());
        }
        static double calcularhamburguer(int quantidade)
        {
            return quantidade * 25.00;
        }
        static double calcularextradip(int quantidade)
        {
            return quantidade * 7.00;
        }
        static double calcularnines(int quantidade)
        {
            return quantidade * 9.00;
        }
        static double calcularlarge(int quantidade)
        {
            return quantidade * 16.00;
        }
    }
}
