using System;

namespace _1._5.CalcularValorComDescontoFormatado
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double desconto;

            Console.Write("Digite o valor do produto: R$");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do desconto: ");
            desconto = double.Parse(Console.ReadLine());

            double porcentagemDescontada = desconto / 100;
            double calcularValorComDesconto = valor - (porcentagemDescontada * valor);

            Console.WriteLine("O produto de valor R${0} com {1}% de desconto obteve o valor final de R${2}", valor, desconto, calcularValorComDesconto);
        }
    }
}
