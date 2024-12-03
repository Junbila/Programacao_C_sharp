using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personagens
{
    internal class Perosnagem1
    {
        //Propriedades (define estado ou caracteristica do Obj)
        public string Nome { get; set; }//por ser publico, permite o acesso e ediçao atraves do get/set

        private int _vida;//queremos ter mais controle, por isso é privado. Usaremos um seleter persongaem

        //encapsulamento da propriedade vida (para controle do seu valor)
        public int vida
        {
            get { return _vida; }
            set
            {
                if (value < 0)
                {
                    _vida = 0;
                }
                else
                {
                    _vida = value;
                }
            }
        }
        //Construtor que é chamada automaticamente 
        public Perosnagem1(string nome, int vida) 
        {
            Nome = nome;
            _vida = vida;
        }
        //Método atacar: Ação que o objeto pode fazer
        public virtual void Atacar()
        {
            Console.WriteLine($"{Nome} atacou com força");
            //O método é virtual, isso significa que pode ser modficado nas classes que herdam de personagens
        }
        public void Mostrarvida() 
        {
            Console.WriteLine($"{Nome} tem {_vida} de Vida!!");
        }

    }
}
