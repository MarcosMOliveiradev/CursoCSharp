using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laço de repetição - while");

        double investimento = 1000;
        double juros = 0.005;
        int mes = 1;

        // laço while

       /* while(mes <= 12)
        {
            investimento = investimento + investimento * juros;
            Console.WriteLine("Seu rendimento no mês " + mes + " foi de R$ " + investimento);

            mes++;
        }*/


        // laço fo
        for(int i = 1; i <= 12; i++)
        {
            investimento = investimento + investimento * juros;
            Console.WriteLine("Seu rendimento no mês " + i + " foi de R$ " + investimento);
        }



        Console.WriteLine("Tecle Enter para sair");
        Console.ReadLine();
    }
}