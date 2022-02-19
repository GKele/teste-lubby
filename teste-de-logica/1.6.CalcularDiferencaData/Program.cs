using System;

namespace _1._6.CalcularDiferencaData
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1, data2;
            TimeSpan resultado;

            Console.WriteLine("Digite uma data: ");
            data1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite outra data: ");
            data2 = DateTime.Parse(Console.ReadLine());

            resultado = data2 - data1;
            Console.WriteLine(resultado.Days);
        }
    }
}
