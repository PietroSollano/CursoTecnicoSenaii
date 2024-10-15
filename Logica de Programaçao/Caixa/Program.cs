
        decimal saldo = 1000.00m; 
        decimal saldoAplicado = 0.00m; 
        decimal taxaRendimento = 0.01m; 
        decimal limiteSaque = 120.00m;  
        bool continuar = true;  

		
		string senhaCorreta = "0802"; 
        int tentativas = 3; 
        bool acessoPermitido = false; 

        
        while (tentativas > 0)
        {
            Console.Write("Digite sua senha: ");
            string senhaDigitada = Console.ReadLine();

            if (senhaDigitada == senhaCorreta)
            {
                Console.WriteLine("Acesso permitido.");
                acessoPermitido = true;
                break;
            }
            else
            {
                tentativas--;
                Console.WriteLine($"Senha incorreta. Você tem {tentativas} tentativas restantes.");
            }
        }

       
        if (!acessoPermitido)
        {
            Console.WriteLine("Número de tentativas excedido. Acesso bloqueado.");
            return; 
        }

        while (continuar)
        {
            
            Console.WriteLine("=== Caixa Eletrônico ===");
            Console.WriteLine("1. Ver Extrato");
            Console.WriteLine("2. Realizar Depósito");
            Console.WriteLine("3. Realizar Saque");
            Console.WriteLine("4. Transferência entre Contas");
            Console.WriteLine("5. Aplicar em Poupança");
            Console.WriteLine("6. Resgatar Poupança");
            Console.WriteLine("7. Verificar Aplicações");
            Console.WriteLine("8. Sair");
            Console.Write("Escolha uma operação: ");

            bool inputValido = int.TryParse(Console.ReadLine(), out int opcao);

            if (!inputValido)
            {
                Console.WriteLine("Erro: Entrada inválida, por favor, digite um número entre 1 e 8.");
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
                        if (valorDeposito > 0)
                        {
                            decimal taxaAplicada = valorDeposito * 0.05m; 
                            saldo += valorDeposito;
                            Console.WriteLine($"Depósito de R${valorDeposito} realizado com sucesso!");
                            Console.WriteLine($"Taxa de 5% aplicada ao depósito: R${taxaAplicada}");
                            Console.WriteLine($"Saldo atual: R${saldo}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: O valor do depósito deve ser maior que zero.");
                        }
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
                            Console.WriteLine($"Saldo atual: R${saldo}");
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
                        else if (valorTransferencia > 0)
                        {
                            saldo -= valorTransferencia; 
                            Console.WriteLine($"Transferência de R${valorTransferencia} realizada com sucesso!");
                            Console.WriteLine($"Saldo atual: R${saldo}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: O valor da transferência deve ser maior que zero.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erro: Valor de transferência inválido.");
                    }
                    break;

                case 5:
                    
                    Console.Write("Digite o valor que deseja aplicar em poupança: R$");
                    if (decimal.TryParse(Console.ReadLine(), out decimal valorAplicar))
                    {
                        if (valorAplicar > saldo)
                        {
                            Console.WriteLine("Erro: Saldo insuficiente para aplicação.");
                        }
                        else if (valorAplicar > 0)
                        {
                            saldo -= valorAplicar;
                            saldoAplicado += valorAplicar; 
                            Console.WriteLine($"Aplicação de R${valorAplicar} realizada com sucesso!");
                            Console.WriteLine($"Saldo atual: R${saldo}");
                            Console.WriteLine($"Saldo aplicado: R${saldoAplicado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: O valor da aplicação deve ser maior que zero.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erro: Valor de aplicação inválido.");
                    }
                    break;

                case 6:
                   
                    if (saldoAplicado > 0)
                    {
                        decimal rendimento = saldoAplicado * taxaRendimento;
                        saldoAplicado += rendimento; 
                        saldo += saldoAplicado; 
                        Console.WriteLine($"Resgate de poupança realizado com sucesso! Valor resgatado: R${saldoAplicado}");
                        saldoAplicado = 0; 
                        Console.WriteLine($"Saldo atual: R${saldo}");
                    }
                    else
                    {
                        Console.WriteLine("Não há saldo aplicado para resgatar.");
                    }
                    break;

                case 7:
                   
                    if (saldoAplicado > 0)
                    {
                        decimal rendimentoAcumulado = saldoAplicado * taxaRendimento;
                        Console.WriteLine($"Saldo aplicado: R${saldoAplicado}");
                        Console.WriteLine($"Rendimento acumulado: R${rendimentoAcumulado}");
                    }
                    else
                    {
                        Console.WriteLine("Não há saldo aplicado.");
                    }
                    break;

                case 8:
                   
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
                Console.ReadLine();
            }
        }
    

             

