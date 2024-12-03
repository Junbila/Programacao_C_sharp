using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_bancaria
{
    internal class conta_bancaria
    {
        //Propriedades da conta
        public string Titular {  get; set; }
        private decimal _saldo;

        //construtor
        public conta_bancaria(string titular, decimal saldoinicial) 
        {
            Titular = titular;
            _saldo = saldoinicial;
        }

        //metodos da conta
        public void exibirsaldo() 
        {
            Console.WriteLine($"Saldo Atual: R$   {_saldo:F2}");
            //F2 garante aparecer 2 casas decimais após os dois pontos
        }
        public void depositar(decimal valor)
        {
            _saldo += valor;
            Console.WriteLine($"\nPeixe caiu!!! total de R$ {valor:F2}");
            exibirsaldo();  
        }
        public void saque(decimal valor)
        {
            if (valor > _saldo)
            {
                Console.WriteLine("\nSaldo indisponível");

            }
            else
            {
                _saldo -= valor;
                Console.WriteLine($"\nSeu saque foi de R$ {valor:F2}");
            }

            exibirsaldo();
        }
    }
}
