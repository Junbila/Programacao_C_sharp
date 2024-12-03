using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    class Reptil : Animal
    {
        private bool Venenoso; //Atributo especifico de repteis

        public Reptil(string nome, int idade, string alimento, bool venenoso)
            : base(nome, idade, alimento) 
        {
            Venenoso = venenoso;
        }
        //Sobrenome o método da classe pai
        public override string Descrever()
        {
            return base.Descrever() + $" É venenoso: {(Venenoso ? "Sim" : "Não ")}";
        }
    }
}
