using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_tarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tarefas = new List<string>();
            int opcao;

            do //faça
            {
                Console.WriteLine("\n Lista de Tarefas");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Remover Tarefa");
                Console.WriteLine("3 - Exibir Tarefas");
                Console.WriteLine("4 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a nova tarefa:");
                        string novaTarefa = Console.ReadLine();
                        tarefas.Add(novaTarefa);
                        Console.WriteLine("Sucesso! Tarefa adicionada");
                        break;

                    case 2:
                        Console.WriteLine("Digite a tarefa a ser removida:");
                        string tarefaRemover = Console.ReadLine();
                        if (tarefas.Remove(tarefaRemover))
                        {
                            Console.WriteLine("Tarefa removida com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível remover");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Lista de tarefas:\n");

                        foreach (string tarefa in tarefas)
                        {
                            Console.WriteLine(tarefa);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != 4); //enquanto
        }
    }
}
