using System;

namespace _1._4.CalcularVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contar vogais de uma String

            string texto;
            int total = 0, i, cont;
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };

            Console.Write("Digite a string: ");
            texto = Console.ReadLine();

            for (i = 0; i <= texto.Length - 1; i++)
            {
                for (cont = 0; cont <= 4; cont++)
                {
                    if (Convert.ToChar(texto.Substring(i, 1)) == vogais[cont])
                    {
                        total++;
                    }
                }
            }
            Console.Write("O total de vogais da string '{0}' é {1}", texto, total);
        }
    }
}
