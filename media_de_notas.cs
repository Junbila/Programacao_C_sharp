using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media; 
            int chance;
                
            Console.WriteLine("Nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
             nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 3: ");
             nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 4: ");
             nota4 = Convert.ToDouble(Console.ReadLine());

             media = (nota1 + nota2 + nota3 + nota4) / 4;
            
            Console.WriteLine("A média do aluno foi: ", media);

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (media  >= 5)
            {
                Console.WriteLine("Ele tirou uma nota na média deseja aprova-lo?>:3");
                 chance = Convert.ToInt32(Console.ReadLine());

                if (chance == 1)
                {
                    media++;
                    Console.WriteLine("Aprovado média de: "+ media++);
                }
                else
                {
                    Console.WriteLine("Recuperação");
                }
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
            Console.ReadKey();  
        }
                  
    }     
}
