using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    internal class Animal
    {
        //atributos protegidos - só são acessivei dentro desta
        protected string Nome; //nome do animal
        protected int Idade; //idade do animal

        //propriedade publica para armazenar a comida do animal
        public string Alimento {  get; private set; }

        //construtor para instanciar o objeto (inicializar atributos)
        public Animal(string nome, int idade,string alimento)
        {
            //vlaidaçoes para garantir que os valores fornecidos sejam validados
            if(string.IsNullOrEmpty(nome)) // Nome não pode ser vazio ou nulo vai retornar falso
            {
                throw new ArgumentNullException("O nome do animal não pode ser vazio ou nulo");
            }

            if (idade < 0)//idade não pode ser negativa
            {
                throw new ArgumentException("A idade não pode ser negativa ou vazia");
            }

            if (string.IsNullOrWhiteSpace(alimento)) //Alimento não pode ser nulo
            {
                throw new ArgumentException("Não pode ser vazio ou nulo");
            }

            //Atributos são inicializados se os valores forem validos

            Nome = nome;
            Idade = idade;
            Alimento = alimento; 
        }


        //Método virtual (permite ser alterado em qualquer lugar)para descrever o animal
        public virtual string Descrever()
        {
            //retornar informações basicas do animal
            return $"Animal : {Nome}, Idade: {Idade}";
        }
    }
}
