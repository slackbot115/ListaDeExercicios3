using System;

namespace Lista3Exerc2
{
//      Escrever um algoritmo que gera e escreve os números ímpares entre 100
//      e 200.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerando numeros impares de 100 a 200... ");
            for (int i = 100; i < 200; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine("Número " + i);
                }
            }
            Console.WriteLine("Digite qualquer tecla para fechar...");
            Console.ReadKey();
        }
    }
}
