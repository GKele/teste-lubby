using System;

namespace _1._7.ObterElementosPares
{
    class Program
    {
        static void ObterElementosPares(int []vetor, int numero)
        {
            for (int i = 0; i < numero; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write(vetor[i] + ", ");
                }
            }
        }

        static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3, 4, 5 };
            int numero = vetor.Length;

            ObterElementosPares(vetor, numero);
        }
    }
}


