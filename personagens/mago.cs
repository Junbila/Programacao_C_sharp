using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personagens
{
    class mago : Perosnagem1
    {
        //Construtor
        public mago(string nome, int vida) : base(nome, vida) { }

        //Sobreescrevendo o metodo atacar
        public override void Atacar()
        {
            Console.WriteLine($"{Nome} lançou Aard");
        }
    }
}
