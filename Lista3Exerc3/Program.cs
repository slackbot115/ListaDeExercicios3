using System;

namespace Lista3Exerc3
{
//      Desenvolver um algoritmo que efetue a soma de todos os números
//      ímpares que são múltiplos de três e que se encontram no conjunto dos
//      números de 1 até 500.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Efetuando calculos...");
            int total = 0;
            for (int i = 1; i < 500; i++)
            {
                if(i % 3 == 0 && i % 2 != 0)
                {
                    total += i;
                }
            }
            Console.WriteLine("A soma de todos os valores multiplos de 3 entre 1 e 500 é " + total);
        }
    }
}
