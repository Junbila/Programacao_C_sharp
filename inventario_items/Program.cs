using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario_items
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            int iteminventario = 0;
            const int maxinventario = 5;
            string escolha;
            bool continuar = true;

            Console.WriteLine("Inventario: "+ iteminventario);
            while (continuar)
            {
                Console.WriteLine("(1) Para adicionar mais items \n(2) Usar item \n(3) sair do inventario");
                escolha = Console.ReadLine();
                Console.Clear();

                if (escolha == "1")
                {
                    if (iteminventario < maxinventario)
                    {
                        Console.WriteLine("Você colocou item no inventario");
                        iteminventario++;
                    }
                    else 
                    {
                        Console.WriteLine("Inventario cheio");
                    }
                }
                if (escolha == "2")
                {
                    if (iteminventario > 0 )
                    {
                        Console.WriteLine("Usou um item ");
                        iteminventario--;
                    }
                    else 
                    {
                        Console.WriteLine("Não há items no inventário");
                    }
                }
                if (escolha == "3")
                {
                    Console.WriteLine("Até mais");
                    break;
                }
                Console.WriteLine("Inventario: " + iteminventario);
            }
            Console.ReadKey();  

        }
    }
}
