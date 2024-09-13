using System;
using System.Xml.Serialization;
using System.Media;
namespace Jogo{
    class Program
    {
        public static int vida = 50, mana = 25, forca = 0, resist = 0, intel = 0;
        public static string diretorio = Directory.GetCurrentDirectory(); // * Obtém o diretório onde o executável está localizado
        // * pra usar o sons, usar esse comando pra formar o caminho string Som = Path.Combine(diretorio, "assets", "aaa.wav");
        public static string?[,] matrizinv = new string?[3 , 3]{
            {null , null , null},
            {null , null , null},
            {null , null , null}};
        public static string? nome;
        static void Main(string[] args)
        {
            //TODO: quando terminar as salas, organizar com o roteiro e colocar os diálogos
            // TODO: Fazer os arquivos separados de cada função, para fins de organização
            /*
            ! Instruções para criar um arquivo.cs, para agregar no jogo
            ! Primeiro: O Nome do arquivo não pode ter espaços nem caracteres especiais, e o nome deve começar com letras maiusculas. Exemplo: Arquivo.cs
            ! Segundo: Usar a estrutura basica aprendida em sala de aula
            ! Exemplo:
            ! using System;
            ! namespace Jogo{
            !    class Arquivo{
            !       public static void Teste(){
            !           Console.WriteLine("Hello World!");
            !       }
            !    }
            ! }
            ! Terceiro: Vale lembrar, a class SEMPRE tem que ter o nome igual ao nome do arquivo.cs
            ! Quarto: Vale lembrar tambem, os codigos tem que terminar com o ; no final, caso contrario o codigo NÃO funciona
            ! Quinto: Pode tirar dúvida com qualquer um, só perguntar no grupo Jettz que alguém vai responder (alguma hora)
            */
            // ! Para chamar qualquer coisa dos outros arquivos.cs, por o nome da classe junto do nome da variavel/função
            
            CriacaoPersonagem.Personagem(); //*leva pra criação de personagem (nome, classe e atributos)
            Combates.ChatGPT(); //*combate contra o chatpgt, no final do jogo
            Combates.InimigoGenerico(); //*combate contra um inimígo genérico (pontos de vida e ataques provisórios)
            Loja.Tonhao(); //*Loja do tonhão (moedas e itens a venda provisórios)
        }

    }
}
