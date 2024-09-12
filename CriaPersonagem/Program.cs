using System;
using System.Xml.Serialization;
namespace Jogo{
    class Program
    {
        public static int vida = 50, mana = 25, forca = 0, resist = 0, intel = 0;
        public static string?[,] matrizinv = new string?[3 , 3]{
            {null , null , null},
            {null , null , null},
            {null , null , null}};
        public static string? nome;
        static void Main(string[] args)
        {
            //TODO: quando terminar as salas, organizar com o roteiro e colocar os diálogos
            // TODO: Fazer os arquivos separados de cada função, para fins de organização
            // ! Para chamar qualquer coisa dos outros arquivos.cs, por o nome da classe junto do nome da variavel/função
            Inventario.ShowInv(matrizinv);
            CriacaoPersonagem.Personagem(); //*leva pra criação de personagem (nome, classe e atributos)
            Combates.ChatGPT(); //*combate contra o chatpgt, no final do jogo
            Combates.InimigoGenerico(); //*combate contra um inimígo genérico (pontos de vida e ataques provisórios)
            Loja.Tonhao(); //*Loja do tonhão (moedas e itens a venda provisórios)
        }

    }
}
