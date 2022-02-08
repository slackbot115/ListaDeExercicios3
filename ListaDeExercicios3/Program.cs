using System;

namespace ListaDeExercicios3
{

//      Desenvolver um algoritmo que leia a altura de 15 pessoas.Este
//      programa deverá calcular e mostrar:

//      Menor altura
//      Maior altura

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] altura = new int[15];
            Console.WriteLine("Digite a altura de 15 pessoas");
            // Pegando as 15 alturas
            for (int i = 0; i < altura.Length; i++)
            {
                Console.Write("Digite a altura da pessoa {0}: ", i);
                altura[i] = int.Parse(Console.ReadLine());
            }

            // Pegando o menor valor
            int min = altura[0];
            for (var i = 0; i < altura.Length; i++)
            {
                if (altura[i] < min)
                    min = altura[i];
            }

            // Pegando o maior valor
            int max = 0;
            for (var i = 0; i < altura.Length; i++)
            {
                if (altura[i] > max)
                    max = altura[i];
            }
                
            Console.WriteLine("Menor altura: {0}", min);
            Console.WriteLine("Maior altura: {0}", max);

            Console.WriteLine("Aperte qualquer tecla para fechar...");
            Console.ReadKey();
        }
    }
}
