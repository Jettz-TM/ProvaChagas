using System;
using System.Media;
namespace Jogo
{
    class Inventario
    {
        public static int linha;
        public static void ShowInv(string?[,] matrizinv)
        {

            for (int i = 0; i < matrizinv.GetLength(0); i++)
            { // * Coluna

                for (int j = 0; j < matrizinv.GetLength(1); j++)
                { // * Linha
                    if (matrizinv[i, j] == null)
                    { // * Caso o inventario esteja vazio (ou nulo) ele escreve "---"
                        Console.Write($"{i + 1}. ---" + "\n");
                    }
                    else
                    {
                        Console.Write(i + 1 + ". " + matrizinv[i, j] + "\n");
                    }
                }
            }
        }
        public static void CheckInv(string?[,] matrizinv)
        {
            Loja.deixa = 0;

            for (int i = 0; i < matrizinv.GetLength(0); i++)
            { // * Coluna

                for (int j = 0; j < matrizinv.GetLength(1); j++)
                { // * Linha
                    if (matrizinv[i, j] != null)
                    {
                        Loja.deixa = Loja.deixa + 1;
                    }
                    else
                    {
                        if (Loja.deixa <= 0)
                        {
                            Loja.deixa = 0;
                        }
                        else
                        {
                            Loja.deixa--;
                        }
                    }
                }
            }
        }


        public static void ChangeInv(string?[,] matrizinv, string item)
        {
            while (true)
            {
                ShowInv(matrizinv); // * Mostra o inventario

                System.Console.WriteLine("Digite o numero da Linha onde deseja adicionar seu item");
                // * Acesso da Linha

                if (!int.TryParse(Console.ReadLine(), out linha) || linha - 1 > 8 || linha - 1 < 0)
                {
                    Console.Clear();
                    System.Console.WriteLine("Escolha um slot valido");
                }
                else if (matrizinv[linha - 1, 0] != null)
                {
                    Console.Clear();
                    System.Console.WriteLine("Ja existe algo nesse slot, favor escolher outro slot");
                }
                else
                {
                    Console.Clear();
                    matrizinv[linha - 1, 0] = item;
                    break;
                }
            }
            Console.Clear();
        }
    }
}