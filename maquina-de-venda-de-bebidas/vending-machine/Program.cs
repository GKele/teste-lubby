using System;

namespace vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendingMachine = new VendingMachine();

            //Comando inicial da Máquina de bebidas
            while (!vendingMachine.verifiqueTotal())
            { 
                Console.WriteLine("Por favor, coloque o dinheiro na máquina (Aceita-se notas de R$2.00, R$5.00, R$10.00 e R$20.00)");
                vendingMachine.DepositoValor(Convert.ToInt32(Console.ReadLine()));
            }
            vendingMachine.MenuBebidas();
            Console.ReadLine();
        }
    }
}
