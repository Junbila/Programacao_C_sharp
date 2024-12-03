using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personagens
{
    class guerreiro : Perosnagem1
    {
        //Construtor - Cria uma instãncia de guerreiro e garante os valores iniciais de nome e vida
        public guerreiro(string nome, int vida) : base(nome, vida) { }
        //Base chama o construtor da classe Personagem, passando os parâmetros do nome e vida.
        //o guerreiro herda essas propriedades sem precisar redefini-las na classe pai.

        //Sobreescrevendo o método atacar de classe bsae para que seja especifico p/ o guerreiro
        public override void Atacar()
        {
            Console.WriteLine($"{Nome} atacou com destreza");
        }
    }
}
