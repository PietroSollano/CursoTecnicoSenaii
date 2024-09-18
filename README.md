# CursoTecnicoSenaii
![alt text](image.png)

# O QUE É?

É um codigo do jogo "pedra papel e tesoura", onde usamos numeros para representar nossas escolhas

# COMO FUNCIONA?

O código te faz uma pergunta, pedindo uma escolha de 1 a 3, com o 1 representando pedra; 2 representando papel; e 3 representando a tesoura.
voce deve escolher 1 desses numeros para prosseguir, e o computador escolhe um elemento aleatorio, e caso voce vença, aparece a mensagem que voce venceu, se voce perde, aparece que voce perdeu, e se da empate, aparece que empatou

# COMO CONSTRUIR?

 string[] opcoes = { "Pedra", "Papel", "Tesoura" };
 Random random = new Random();
 Usamos a variavel string com array, e declaramos opcoes como um array, e colocamos escolhas, e abaixo, usamos o random, para gerar um escolha aleatoria

  static string DeterminarVencedor(int jogador, int computador)
    {
        if (jogador == computador)
        {
            return "Empate!";
        }
        else if ((jogador == 1 && computador == 3) || 
                 (jogador == 2 && computador == 1) || 
                 (jogador == 3 && computador == 2))  
        {
            return "Você venceu!";
        }
        else
        {
            return "Computador venceu!";
        }
    }

    usamos o static para iniciar o jogo, e fazer o computador fazer escolhas aleatorias, gerando assim o jogo, e usamos o return para reiniciar o jogo, mesmo que tenha perdido ou nao

# CÓDIGO
using System;

public class Program
{
    public static void Main()
    {
        string[] opcoes = { "Pedra", "Papel", "Tesoura" };
        Random random = new Random();
        
        while (true) 
        {
            
            Console.WriteLine("Escolha um elemento:");
            Console.WriteLine("1) Pedra");
            Console.WriteLine("2) Papel");
            Console.WriteLine("3) Tesoura");
            Console.WriteLine("0) Sair");
            
            if (!int.TryParse(Console.ReadLine(), out int escolhaJogador) || escolhaJogador < 0 || escolhaJogador > 3)
            {
                Console.WriteLine("Escolha inválida! Tente novamente.");
                continue;
            }

            if (escolhaJogador == 0)
            {
                Console.WriteLine("Saindo do jogo...");
                break;
            }

            
            string escolhaJogadorStr = opcoes[escolhaJogador - 1];
            Console.WriteLine($"Você escolheu: {escolhaJogadorStr}");

            
            int escolhaComputador = random.Next(1, 4); 
            string escolhaComputadorStr = opcoes[escolhaComputador - 1];
            Console.WriteLine($"Computador escolheu: {escolhaComputadorStr}");

            
            string resultado = DeterminarVencedor(escolhaJogador, escolhaComputador);
            Console.WriteLine(resultado);

            Console.WriteLine();
        }
    }

    static string DeterminarVencedor(int jogador, int computador)
    {
        if (jogador == computador)
        {
            return "Empate!";
        }
        else if ((jogador == 1 && computador == 3) || 
                 (jogador == 2 && computador == 1) || 
                 (jogador == 3 && computador == 2))  
        {
            return "Você venceu!";
        }
        else
        {
            return "Computador venceu!";
        }
    }
}

