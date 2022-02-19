using System;

namespace vending_machine
{
    class VendingMachine
    {

		//Valor dos produtos
		const double valorAgua = 1.50;
		const double valorCoca = 4.50;
		const double valorSuco = 3.00;
		public int total { get; set; }

		public VendingMachine()
		{
			total = 0;
		}

		public void DepositoValor(int dinheiro)
		{
			//Os valores de entrada de dinheiro podem ser R$2,00, R$5,00, R$10,00 e R$20,00
			switch (dinheiro)
			{
				case (2):
					total += 2;
					break;

				case (5):
					total += 5;
					break;

				case (10):
					total += 10;
					break;

				case (20):
					total += 20;
					break;
				default:
					Console.WriteLine("Valor não permitido!");
					break;
			}
		}

		//Verificando se houve entrada de dinheiro
		public bool verifiqueTotalAgua()
        {
			if (total >= valorAgua)
				return true;
			else
				return false;
        }

		public bool verifiqueTotal()
		{
			if (total >= valorCoca)
            {
				return true;

            }
			if (total >= valorSuco)
            {
				return true;
            }

			if (total >= valorSuco)
            {
				return true;
            }
			else
				return false;
		}

		//Menu da máquina
		public void MenuBebidas()
		{
			Console.WriteLine("----------- MENU DE OPÇÕES --------");
			Console.WriteLine("|       [1] - Água       R$1.50   |");
			Console.WriteLine("|       [2] - Coca-cola  R$4.50   |");
			Console.WriteLine("|       [3] - Suco       R$3.00   |");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine();
			Console.WriteLine("Selecione uma opção do menu:");
			BebidaSelecionada(Convert.ToChar(Console.ReadLine()));

		}

		//Verificando a opção escolhida e calculo do troco (se houver)
		public void BebidaSelecionada(char opcao)
        {
			bool opcaoOK = false;
			while (!opcaoOK)
            {
                switch (opcao)
                {
					case '1':
						Console.WriteLine("Você escolheu a água.");
						DevolverTrocoAgua(); 
						opcaoOK = true;
						break;
					case '2':
						Console.WriteLine("Você escolheu a coca-cola.");
						DevolverTrocoCoca();
						opcaoOK = true;
						break;
					case '3':
						Console.WriteLine("Você escolheu o suco.");
						DevolverTrocoSuco();
						opcaoOK = true;
						break;
					default:
						Console.WriteLine("Opção inexistente, por favor selecione uma opção valida!");
						opcao = Convert.ToChar(Console.ReadLine());
						opcaoOK = false;
						break;
				}
			}
        }

		private void DevolverTrocoAgua()
        {
			if (total > valorAgua)
				Console.WriteLine("O seu troco é R${0}", total - valorAgua);
				Console.WriteLine("Precisone enter para sair.");
        }
		private void DevolverTrocoCoca()
		{
			if (total > valorCoca)
				Console.WriteLine("O seu troco é R${0}.", total - valorCoca);
				Console.WriteLine("Precisone enter para sair.");
		}
		private void DevolverTrocoSuco()
		{
			if (total > valorSuco)
				Console.WriteLine("O seu troco é R${0}", total - valorSuco);
				Console.WriteLine("Precisone enter para sair.");
		}

	}
}
