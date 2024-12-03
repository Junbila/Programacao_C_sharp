using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilheteria_estadio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int capacidademaX = 50000;//capacidade pré-definida do estádio
            int qtdvendidos = 0, qtdingresso, torcedores,qtdtorcedorfila;
            double precoingresso, total = 0.0; //valores decimais com uso de ','

            Console.WriteLine("Preço Do Ingresso: ");
            precoingresso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantidades disponíveis: ");
            qtdingresso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Torcedores na fila: ");
            qtdtorcedorfila = Convert.ToInt32(Console.ReadLine());

            while (qtdingresso > 0 && qtdtorcedorfila > 0) 
            {
                if (qtdingresso > capacidademaX)
                {
                    Console.WriteLine("Não há ingressos á venda");
                }
                else 
                {
                    Console.WriteLine
                }
            }
             

            Console.ReadKey();
        }       
    }
}
