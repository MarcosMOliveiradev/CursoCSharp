using System;
/*
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome;
            nome = new string[5];

            nome[0] = "Marcos";
            nome[1] = "Guilherme";
            nome[2] = "João";
            nome[3] = "Ana";
            nome[4] = "Zé";

           // Console.WriteLine(nome[1]);

            // Para mostrar tos os itens dentro do array e necessario usar um laço de repetição "foreach"
            foreach( string nomes in nome)
            {
                Console.WriteLine(nomes);
            }
        }
    }
} */

//************ Exercicio de ordenação ************//
/*
namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 10 números  inteiro > 0
             vetor que armazene numeros pares 
            vetor que armazene numeros impares
            exibir TODOS os números em ordem crescente 

            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];


            // incrementa um numero na variavel "numeros"
            for (int p = 0; p < numeros.Length; p++)
            {
                Console.WriteLine("Digite um numero maior que 0");
                numeros[p] = Convert.ToInt32(Console.ReadLine());

            }


            // Verifica se o numero é par ou impa
            for ( int p = 0; p < numeros.Length; p++)
            {
                if (numeros[p] % 2 == 0)
                {
                    pares[p] = numeros[p];
                }
                else
                {
                    impares[p] = numeros[p];
                }
            }

            Array.Sort(numeros);
            Array.Sort(pares);
            Array.Sort(impares);

            Console.WriteLine("Estes são os número que você digitou: ");
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("\n\nEstes são os numero pares:");

            foreach(int numero in pares)
            {
                if(numero != 0) Console.WriteLine(numero);
            }

            Console.WriteLine("\n\nEstes são os numero impares:");

            foreach (int numero in impares)
            {
                if (numero != 0) Console.WriteLine(numero);
            }
        }
    }
} */

//********** Exercio com vetores de duas dimenções **********//

namespace VetoresDuasDimencoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 estudantes
            // Idade dos estudantes
            // Exibir em ordem dos mais velhos pros mais novos

            String[] estudantes = new String[10];
            int[] idade = new int[10];
            String[] lista = new String[10];


            Console.WriteLine("Digite o nome de 10 alunos e suas respectiva idade");
            Console.ReadLine();

            for(int p = 0; p < estudantes.Length; p++ )
            {
                Console.WriteLine("Nome dos estudantes");
                estudantes[p] = Console.ReadLine();

                Console.WriteLine("Idade do estudante");
                idade[p] = Convert.ToInt16(Console.ReadLine());


                if (idade[p] < 10)
                {
                    lista[p] = 0 + idade[p] + " " + estudantes[p];
                } else
                {
                    lista[p] = idade[p] + " " + estudantes[p];
                }
            }

            Array.Sort(lista);
            foreach(String p in lista)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("O estudante mais velho é o " + lista.Length);
            Console.WriteLine("O estudante mais novo é o " + lista[0]);
        }
    }
}