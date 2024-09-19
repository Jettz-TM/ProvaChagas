using System;
using System.Xml.Serialization;
using System.Media;
namespace Jogo
{
    class Program
    {
        public static string diretorio = Directory.GetCurrentDirectory(); // * Obtém o diretório onde o executável está localizado
        // * pra usar o sons, usar esse comando pra formar o caminho string Som = Path.Combine(diretorio, "assets", "aaa.wav");
        public static string?[,] matrizinv = new string?[9, 1]{
            {null},
            {null},
            {null},
            {null},
            {null},
            {null},
            {null},
            {null},
            {null},};
        public static string? nome;
        public static void Main(string[] args)
        {
            string Som = Path.Combine(Program.diretorio, "assets", "introechegada.wav");
            System.Media.SoundPlayer introechegada = new System.Media.SoundPlayer(Som);
            // TODO: quando terminar as salas, organizar com o roteiro e colocar os diálogos
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
            ! Quinto: Pode tirar dúvidaTotal com qualquer um, só perguntar no grupo Jettz que alguém vai responder (alguma hora)
            */
            // ! Para chamar qualquer coisa dos outros arquivos.cs, por o nome da classe junto do nome da variavel/função

            MenuInicio.Menu(); //* leva pro menu
            CriacaoPersonagem.Personagem(); //*leva pra criação de personagem (nome, classe e atributos)
            introechegada.PlayLooping();
            Salas.Introdução();
            Salas.Sala1();
            introechegada.Stop();
            Salas.Sala2();
            Salas.Sala3();
            Salas.Sala4();
            Salas.Sala5ponto1();
            Salas.Sala5();
            Salas.Sala6();
            Salas.Sala7();
            Salas.Sala8();
            Salas.Sala9();
            Salas.Final();

            // * combate contra o chat gpt e a loja do tonhão em comentario pq ainda não tão 100%
            // * ou a parte em que els entram ainda não foi terminada

            // Combates.ChatGPT(); //* combate contra o chatpgt, no final do jogo
            //Loja.Tonhao(); //*Loja do tonhão (moedas e itens a venda provisórios)
        }

    }
}
