using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int combustivel = 100;
            int consumo = 5;
            int capacidade = 20; 
            int capacidademax = 100;

            Console.WriteLine("Você entrou no carro, Digite [Acelerar] para começar a dirigir");
            string escolha = Console.ReadLine().ToLower();

            if (escolha == "acelerar")
            {
                Console.WriteLine("O carro está se movendo");

                while (combustivel > 0) 
                {
                    //Diminuir Combusivel
                    combustivel -= consumo;
                    Console.Clear();    

                    Console.WriteLine("Carro em movimento\n (P) para parar Pressione (A) para abastecer");
                    Console.WriteLine("Combustivel restante: "+ combustivel);  

                    // Verificar se o combustivel esta no nivel de reserva
                    if (combustivel <= capacidade && combustivel > 0) 
                    {
                        Console.WriteLine("Alerta, Reserva");
                        Console.Beep(1000, 500); //Hz e Ms
                    }
                    if (combustivel <= 0) 
                    {
                        Console.WriteLine("O combustivel acabou");
                        break;
                    }
                    //pausa para simular o consumo.
                    Thread.Sleep(1000);

                    //verifica se alguma tecla foi pressionada
                    if (Console.KeyAvailable)
                    {
                        char tecla = Console.ReadKey(true).KeyChar;
                        if (char.ToUpper(tecla) == 'P') 
                        {
                            Console.WriteLine("\nVocê parou\n simulação encerrada\n");
                            Console.WriteLine("Combustivel restante: "+ combustivel);
                                              
                        }
                        if (char.ToUpper(tecla) == 'A')
                        {
                            Console.WriteLine("Abastecido!!");
                            if ((combustivel + 50) <= capacidademax) 
                            {
                                combustivel += 50;
                                Thread.Sleep(1000);
                                Console.WriteLine("Combustivel: " + combustivel);
                            } 
                            else 
                            {
                                combustivel = capacidademax;

                            }
                            
                        }
                    }
                }
            }
            else 
            {
                Console.WriteLine("Opção invalida");
            }
            Console.WriteLine("FIM");
            Console.ReadKey();
        }
        
    }
}
