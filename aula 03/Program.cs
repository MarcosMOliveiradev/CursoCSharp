using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Escreva um numero");
        double numero_1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escreva o segundo numero");
        double numero_2 = Convert.ToDouble(Console.ReadLine());

        double total = numero_1 + numero_2;

        double salario = 3000.13;

        Console.WriteLine("O total da soma é " + total);

        Console.WriteLine("Tecle enter para sair");
        Console.ReadLine();
    }
}