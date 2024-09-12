using System;
namespace Jogo{
    class Inventario{
        public static void ShowInv(string?[,] matrizinv){

            for (int i = 0; i < matrizinv.GetLength(0); i++){ // * Coluna

                for (int j = 0; j < matrizinv.GetLength(1); j++){ // * Linha
                    if (matrizinv[i,j] == null){ // * Caso o inventario esteja vazio (ou nulo) ele escreve "---"
                        Console.Write("---" + " ");
                    }
                    else{
                        Console.Write(matrizinv[i, j] + " ");
                    }
                }
                Console.WriteLine(); // Pula para a próxima linha após cada linha da matriz
            }
        }
        public static void ChangeInv(string?[,] matrizinv){
            int coluna, linha;
            string item = "Poção";
            while(true){
                ShowInv(matrizinv); // * Mostra o inventario

                System.Console.WriteLine("Digite o numero da Coluna onde deseja adicionar seu item");
                int.TryParse(Console.ReadLine(), out coluna); // * Acesso da coluna

                Console.Clear();
                ShowInv(matrizinv);

                System.Console.WriteLine("Digite o numero da Linha onde deseja adicionar seu item");
                int.TryParse(Console.ReadLine(), out linha); // * Acesso da linha

                if(matrizinv[coluna,linha] != null){
                    System.Console.WriteLine("Ja existe algo nesse slot, favor escolher outro slot");
                }
                else{
                    matrizinv[coluna,linha] = item;
                    break;
                }
            }
        }
    }
}