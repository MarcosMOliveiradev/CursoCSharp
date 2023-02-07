using System;

namespace TratandoError
{
    public class ContaCorrente
    {
        private int Agencia;
        private int Numero;

        public static double TaxaOperacao { get; private set; }
        public static double TotalDeContasCriadas { get; private set; }

        public ContaCorrente(int Agencia, int Numero)
        {
            Agencia = Agencia;
            Numero = Numero;

            try
            {
                TotalDeContasCriadas++;
                TaxaOperacao = 30 / TotalDeContasCriadas;
                Console.WriteLine("O resultado é " + TaxaOperacao);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Não é possivel dividir por 0!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente(9999, 123456);
            ContaCorrente conta2 = new ContaCorrente(8888, 654321);
        }
    }
}