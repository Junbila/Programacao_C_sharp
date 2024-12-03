using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
        class Ave : Animal

        {
            private bool PodeVoar; //Atributo específico das aves

            public Ave(string nome, int idade, string alimento, bool Podevoar) : base(nome, idade, alimento) //Chama o construtor da classe base
            {
                PodeVoar = Podevoar;
            }
            //sobreescreve o método para adicional informaçoes especificas
            public override string Descrever()
            {
                return base.Descrever()+ $"Pode voar: {(PodeVoar ? "Sim" : "Não")}";
            }
        }
}
