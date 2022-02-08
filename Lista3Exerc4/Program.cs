using System;

namespace Lista3Exerc4
{
//          Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
//          calcule a tabuada de N.

//          Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N =
//          10N.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");
            Console.WriteLine("Digite um valor: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, num, (num * i));
            }
            Console.WriteLine("Digite qualquer tecla para fechar...");
            Console.ReadKey();
        }
    }
}
