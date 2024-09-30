using System;

public class HelloWorld
{
	public static void Main(string[] args)
	{
		int quantidadeDezenas = 0, quantidadeJogos = 0;
		decimal valpremio;
		bool repetir = false;
		int dezenas;
		do
		{
			// peça ao usuário para inserir a quantidade de Jogos
			Console.Write("insira a quantidade de Jogos: ");
			if (int.TryParse(Console.ReadLine(), out int quantidadeJ))
			{
				quantidadeJogos = quantidadeJ;
				repetir = false;
				// peça ao usuário para inserir a quantidade de dezenas
				Console.Write("insira a quantidade de dezenas: ");
				if (int.TryParse(Console.ReadLine(), out int quantidadeD))
				{
					quantidadeDezenas = quantidadeD;
					if (quantidadeDezenas >= 6 && quantidadeDezenas <= 15)
					{
						repetir = false;
					}
					else
					{
						repetir = true;
					}
				}
				else
				{
					Console.WriteLine("numero inválido! Tente Novamente ");
					repetir = true;
				}
			}
			else
			{
				Console.WriteLine("numero inválido! Tente Novamente ");
				repetir = true;
			}

			Console.Clear();
		}
		while (repetir == true);
		Console.WriteLine();
		// gere um jogo aleatorio de acordo com o que o usuário pedir
		Random random = new Random();
		if (quantidadeDezenas >= 6 && quantidadeDezenas <= 15)
		//estrutura de repetição para a quantidade de jogos
		{
			using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))
			{
			for (int contadorJogos = 1; contadorJogos <= quantidadeJogos; contadorJogos++)
			{
				//estrutura de repetição para a quantidade de dezenas
				for (int contador = 1; contador <= quantidadeDezenas; contador++)
				{
					dezenas = random.Next(1, 61);
					if (contador == quantidadeDezenas)
					{
						Console.Write($"{dezenas:D2}\n");
						escrever.Write($"{dezenas:D2}\n");
					}
					else
					{
						Console.Write($"{dezenas:D2}-");
						escrever.Write($"{dezenas:D2}-");
					}
				}
			}
			}

			Console.WriteLine();
			//peça ao usuário que informe o valor do prêmio
			Console.WriteLine("informe o valor do prêmio: ");
			valpremio = decimal.Parse(Console.ReadLine());
			//quem acertar 6 dezenas ganha 75% do prêmio, 15% para quem acertar 5 dezenas e 10% para quem acertar 4 dezenas
			decimal valpremio6dez = valpremio * 0.75m;
			decimal valpremio5dez = valpremio * 0.15m;
			decimal valpremio4dez = valpremio * 0.10m;
			Console.WriteLine($"{valpremio6dez}-valor para quem acertar 6 dezenas ");
			Console.WriteLine($"{valpremio5dez}-valor para quem acertar 5 dezenas ");
			Console.WriteLine($"{valpremio4dez}-valor para quem acertar 4 dezenas ");
		}
	}
}