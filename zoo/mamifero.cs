using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    class Mamifero : Animal
    {
        public Mamifero(string nome, int idade, string alimento)
            : base(nome, idade, alimento)
        { }
        public override string Descrever()
        {
            return base.Descrever() + "Tipo: Mamífero";
        }
    }
}
