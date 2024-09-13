using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Dungeon SENAI. Esse é o menu principal!");
        Console.WriteLine("Digite 1 para entrar.");
        Console.WriteLine("Digite 2 para sair.");
        Console.Write("Digite sua opção: ");

        
        string escolha = Console.ReadLine();

        
        switch (escolha)
        {
            case "1":
                CriarPersonagem();
                break;

            case "2":
                Console.WriteLine("Saindo do jogo...");
                Environment.Exit(0); // Correção do nome do método Environment
                break;

            default:
                Console.WriteLine("Opção inválida");
                MenuInicial();
                break;
        }
    }

    
    static void CriarPersonagem()
    {
        Console.Write("Insira o nome do personagem: ");
        string nomePersonagem = Console.ReadLine();
        Console.WriteLine($"Bem-vindo, {nomePersonagem}!");
    }

    
    static void MenuInicial()
    {
        Main(null); // Chama o menu inicial novamente
    }
}
