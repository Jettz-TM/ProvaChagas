using System;
using System.Xml.Serialization;
using System.Media;
namespace Jogo
{
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Dungeon SENAI. Esse é o menu principal!");
        Console.WriteLine("Digite 1 para entrar.");
        Console.WriteLine("Digite 2 para sair.");
        Console.Write("Digite sua opção: ");

        // Leitura da escolha do usuário
        string escolha = Console.ReadLine();

        // Switch para tratar as opções
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

    // Função para criar personagem
    static void CriarPersonagem()
    {
        Console.Write("Insira o nome do personagem: ");
        string nomePersonagem = Console.ReadLine();
        Console.WriteLine($"Bem-vindo, {nomePersonagem}!");
    }

    // Função para retornar ao menu inicial
    static void MenuInicial()
    {
        Main(null); // Chama o menu inicial novamente
    }
}
}
