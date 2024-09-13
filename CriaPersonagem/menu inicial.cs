using System

class Program
{
    static void Main()
    {
        Console.Write("Bem bindo ao dungeon senai, esse e o menu principal")
        Console.Write("Digite 1 para entrar ")
        Console.Write("Digite 2 para sair ")
        console.WriteLine("Digite sua opção: ")
        string escolha = Console.ReadLine
        switch(escolha)
        case "1"
        CriarPersonagem();
        break;
        case "2"
        Console.WriteLine("saindo do jogo...")
        Enviroment.Exit(0);
        break;
        default:
        Console.WriteLine("Opção invalida")
        MenuInicial();
        break;
        static void CriarPersonagem()
        Console.Write("insiraa o nome do seu personagem: ")
        string nomePersonagem = Console.ReadLine();
        Console.WriteLine($"bem-vindo {nomePersonagem}!")
        

    }
}
