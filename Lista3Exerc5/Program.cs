using System;

namespace Lista3Exerc5
{
//      Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
//      valores do cálculo de A! e o seu resultado.


    internal class Program
    {
        public static string InverteString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um valor para calcular seu fatorial: ");
            int num = int.Parse(Console.ReadLine());
            int fat_num = 1;
            if(num == 0)
            {
                Console.WriteLine("Fatorial de 0 é 1");
                Console.WriteLine("Aperte qualquer tecla para fechar...");
                Console.ReadKey();
            }
            else
            {
                string sequencia = "";
                for (int i = 1; i < num; i++)
                {
                    fat_num += fat_num * i;
                    sequencia += i + " X ";
                }
                string reverse_sequencia = InverteString(sequencia);
                // 5! = 5 X 4 X 3 X 2 X 1 = 120
                Console.WriteLine("{0}! = {0}{1} = {2}", num, reverse_sequencia, fat_num);
                Console.WriteLine("Aperte qualquer tecla para fechar...");
                Console.ReadKey();
            }
        }
    }
}
