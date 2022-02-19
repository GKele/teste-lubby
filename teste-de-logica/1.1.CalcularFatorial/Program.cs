using System;

namespace _1._1.CalcularFatorial
{
    class Program
    {       static void Main (string[] args)
            {
                //Calcular fatorial de um número

                int numero, fatorial, contador;
                numero = 0;
                fatorial = 1;

                Console.Write("Digite um número:");
                numero = int.Parse(Console.ReadLine());

                for (contador = numero; contador >= 1; contador--)
                {
                    fatorial *= contador;
                }
                Console.WriteLine("O fatorial de {0} é {1}", numero, fatorial);
            }
    }
}
