Console.WriteLine(" ");
		Console.WriteLine("use 1 para sim e 0 para nao\n");
		Console.WriteLine("A BOIA A ESTA LIGADA?");
		double boia1 = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("A BOIA B ESTA LIGADA?");
		double boia2 = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("A BOIA C ESTA LIGADA?");
		double boia3 = Convert.ToDouble(Console.ReadLine());

		
		if (boia1 == 0 && boia2 == 0 && boia3 == 0)
		{
			Console.WriteLine("Ligue a válvula");
		}
	 	else if (boia1 == 1 && boia2 == 0 && boia3 == 0)
		{
			Console.WriteLine("Ligue a válvula");
		}
		else if (boia1 == 0 && boia2 > 0 )
		{
			Console.WriteLine("Erro");
		}
		else if (boia1 == 1 && boia2 == 1 && boia3 == 0)
		{
			Console.WriteLine("Ligue a bomba");
			Console.WriteLine("desligue a valvula");
		
		}
		else if (boia1 == 1 && boia2 == 1 && boia3 == 1)
		{
			
			Console.WriteLine("desligue a bomba");
			Console.WriteLine("A caixa d'agua esta cheia");
		}
	
		
		else
		{
			Console.WriteLine("Condição inválida.");
		}
