using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_a_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construtor - cria um objeto do tipo mensagem
            Mensagem msg1 = new Mensagem();
            msg1.textoMensagem = "Primeira Classe";

            msg1.ExibirMensagem();

            Mensagem2 msg2 = new Mensagem2();
            msg2.textoparabens = "Primeira Classe";

            msg2.ExibirParabens();

            Console.ReadKey();
        }
    }
}
