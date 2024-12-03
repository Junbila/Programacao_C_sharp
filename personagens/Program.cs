using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personagens
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crias instancias de guerreiro e mago
            Perosnagem1 guerreiro = new guerreiro("Zoro", 100);
            Perosnagem1 mago = new mago("Patolino", 70);

            //Mostra personagens e Vida
            guerreiro.Mostrarvida();
            mago.Mostrarvida();

            guerreiro.Atacar();
            mago.Atacar();

            //Modificar e mostrar
            guerreiro.vida -= 30;
            mago.vida -= 20;

            guerreiro.Mostrarvida();
            mago.Mostrarvida();

            //Tentar continuar com vida negativa
            mago.vida = -50;
            mago.Mostrarvida();

            Console.ReadKey();
        }
    }
}
