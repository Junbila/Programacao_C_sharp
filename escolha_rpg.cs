using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fase;
            bool armadura = true, casaco = true;
            

            Console.WriteLine("Você precisa prossegir em qual mapa deseja ir primeiro: \n [1] Floresta Encantada [2] Montanha Congelada [3] Fortaleza do Boss");
            fase = Convert.ToInt32(Console.ReadLine());

            if (fase == 1) 
            {
                Console.WriteLine("Você está indo para a Floresta Encantada");
            }
            else if (fase == 2) 
            {
                Console.WriteLine("Está com casaco equipado?\n 1 - Sim 2 - Não");
                casaco = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine())); 
                
                if (casaco == false)

                {  
                    Console.WriteLine("Você está indo para Montanha Congelada");
                }
                else 
                {
                    Console.WriteLine("Volte quando estiver com um casaco");
                }
                if (fase == 3)
                {
                    Console.WriteLine("Você está indo para a Fortaleza do Boss");
                }
                else
                    Console.WriteLine("Está com casaco equipado?\n 1 - Sim 2 - Não");
                armadura = Convert.ToBoolean(Convert.ToInt32(Console.ReadKey()));

                if (armadura == false)
                {
                    Console.WriteLine("Volte quando estiver preparado");
                }
            Console.ReadKey();
            } 
        }   
    }
}
