
        decimal saldo = 1000.00m;  
        decimal limiteSaque = 500.00m;  
        string tipoConta = "corrente";  
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Caixa Eletrônico ===");
            Console.WriteLine("1. Ver Extrato");
            Console.WriteLine("2. Realizar Depósito");
            Console.WriteLine("3. Realizar Saque");
            Console.WriteLine("4. Transferência entre Contas");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma operação: ");
            
            
            bool inputValido = int.TryParse(Console.ReadLine(), out int opcao);

            if (!inputValido)
            {
                Console.WriteLine("Erro: Entrada inválida, por favor, digite um número entre 1 e 5.");
                Console.ReadKey();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    
                    Console.WriteLine($"Saldo atual: R${saldo}");
                    break;

                case 2:
                    
                    Console.Write("Digite o valor do depósito: R$");
                    if (decimal.TryParse(Console.ReadLine(), out decimal valorDeposito))
                    {
                        saldo += valorDeposito;
                        Console.WriteLine($"Depósito de R${valorDeposito} realizado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Valor de depósito inválido.");
                    }
                    break;

                case 3:
                    
                    Console.Write("Digite o valor do saque: R$");
                    if (decimal.TryParse(Console.ReadLine(), out decimal valorSaque))
                    {
                        if (valorSaque > saldo)
                        {
                            Console.WriteLine("Erro: Saldo insuficiente.");
                        }
                        else if (valorSaque > limiteSaque)
                        {
                            Console.WriteLine($"Erro: O valor excede o limite de saque permitido de R${limiteSaque}.");
                        }
                        else
                        {
                            saldo -= valorSaque;
                            Console.WriteLine($"Saque de R${valorSaque} realizado com sucesso!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erro: Valor de saque inválido.");
                    }
                    break;

                case 4:
                    
                    Console.Write("Digite o valor da transferência: R$");
                    if (decimal.TryParse(Console.ReadLine(), out decimal valorTransferencia))
                    {
                        if (valorTransferencia > saldo)
                        {
                            Console.WriteLine("Erro: Saldo insuficiente para transferência.");
                        }
                        else
                        {
                            saldo -= valorTransferencia;
                            Console.WriteLine($"Transferência de R${valorTransferencia} realizada com sucesso!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erro: Valor de transferência inválido.");
                    }
                    break;

                case 5:
                    
                    continuar = false;
                    Console.WriteLine("Obrigado por usar o Caixa Eletrônico.");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            
            if (continuar)
            {
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    


             

