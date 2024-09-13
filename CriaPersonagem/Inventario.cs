using System;
using System.Media;
namespace Jogo{
    class Inventario{
        public static void ShowInv(string?[,] matrizinv){

            for (int i = 0; i < matrizinv.GetLength(0); i++){ // * Coluna

                for (int j = 0; j < matrizinv.GetLength(1); j++){ // * Linha
                    if (matrizinv[i,j] == null){ // * Caso o inventario esteja vazio (ou nulo) ele escreve "---"
                        Console.Write("---" + "\n");
                    }
                    else{
                        Console.Write(matrizinv[i, j] + "\n");
                    }
                }
            }
        }
        public static void ChangeInv(string?[,] matrizinv, string item){
            int coluna = 0, linha;
            while(true){
                ShowInv(matrizinv); // * Mostra o inventario

                System.Console.WriteLine("Digite o numero da Linha onde deseja adicionar seu item");
                 // * Acesso da Linha

                if(!int.TryParse(Console.ReadLine(), out linha) || linha-1 > 8 || linha -1 < 0){
                    Console.Clear();
                    System.Console.WriteLine("Escolha um slot valido");
                }
                else if(matrizinv[linha -1, coluna] != null){
                    Console.Clear();
                    System.Console.WriteLine("Ja existe algo nesse slot, favor escolher outro slot");
                }
                else{
                    Console.Clear();
                    matrizinv[linha -1, coluna] = item;
                    break;
                }   
            }
            Console.Clear();
        }
    }
}