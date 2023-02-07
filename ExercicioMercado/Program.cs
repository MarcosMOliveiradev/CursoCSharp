using System;


/*
namespace EstoqueMercado
{
    class EstoqueItem
    {
        public String Nome;
        public String Fabricante;
        public int CodigoDeBarras;
        public int ValorUnitario;
        public int ValorCompra;
        public int Quantidade;


    }
} */

namespace Banco
{
    public class ContaCorrente
    {
        public int numeroAgencia;
        public string conta;
        public string titular;
        public double saldo;


        // crindo metodo de deposito
        public void Depositar( double valor)
        {
            this.saldo += valor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaMarcos = new ContaCorrente();
            ContaMarcos.numeroAgencia = 15;
            ContaMarcos.conta = "1010-x";
            ContaMarcos.titular = "Marcos";
            ContaMarcos.saldo = 95;

            Console.WriteLine("Seu saldo é de: " + ContaMarcos.saldo);

            Console.WriteLine("Digite quanto você esta depositando");
            int deposito = Convert.ToInt32(Console.ReadLine());

            ContaMarcos.Depositar(deposito);

            Console.WriteLine("Seu saldo é de: " + ContaMarcos.saldo);

        }
    }
}
