using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando conta bancaria
            conta_bancaria conta = new conta_bancaria("Peppa Poggers da Silva", 10000.00m);

            //Exibindo iformações iniciais
            Console.WriteLine($"Bem vindo(a). {conta.Titular}");

            conta.exibirsaldo();
            Console.ReadKey();

            int escolha;
            do
            {
                exibirmenu();
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Digite o Valor de depósito: ");
                        decimal valordepos = Convert.ToDecimal(Console.ReadLine());
                        conta.depositar(valordepos);
                        break;

                    case 2:
                        Console.WriteLine("Valor do saque: ");
                        decimal valorsaque = Convert.ToDecimal(Console.ReadLine());
                        conta.saque(valorsaque);
                        break;

                    case 3:
                        conta.exibirsaldo();
                        break;

                    case 4:
                        Console.Clear();
                        //Exibindo info iniciais
                        Console.WriteLine($"Bem vindo(a). {conta.Titular}");
                        break;

                    case 5:
                        Console.WriteLine("Obrigado por usar o sistema do TRABANK");
                        break;

                }
            } while (escolha != 5);
            
           
            
            Console.ReadKey();

        }

        public static void exibirmenu()
        {
            Console.WriteLine("\nEscolha uma opção");
            Console.WriteLine(" 1 - Depositar");
            Console.WriteLine(" 2 - Sacar");
            Console.WriteLine(" 3 - Exibir Saldo");
            Console.WriteLine(" 4 - Reiniciar");
            Console.WriteLine(" 5 - Sair");
        }

    }
}
