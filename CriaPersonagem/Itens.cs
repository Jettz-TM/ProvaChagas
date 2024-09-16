using System;
namespace Jogo
{
    class Itens
    {
        public static void Acess(string?[,] matrizinv, int linha){
            if (matrizinv[linha - 1, 0] == null){
                System.Console.WriteLine("Não existe nada aqui");
            }
            else if(matrizinv[linha - 1 , 0] == "Salgado"){
                Salgado(Program.matrizinv, Combates.pode);
            }
            else if(matrizinv[linha - 1, 0] == "Energetico"){
                Energetico(Program.matrizinv, Combates.pode);
            }
            else if(matrizinv[linha - 1, 0] == "Soco Inglês"){
                ItemPassivo();
            }
            else if(matrizinv[linha - 1, 0] == "Uniforme do Interclasse"){
                ItemPassivo();
            }
            
            
        }
        public static void Salgado(string?[,] matrizinv, bool pode)
        {
            int potion = 15;

            if (CriacaoPersonagem.vida >= CriacaoPersonagem.vidaTotal)
            {
                CriacaoPersonagem.vida = CriacaoPersonagem.vidaTotal;
                Console.WriteLine("Tua vida ta cheia seu jumento");
            }

            else if (CriacaoPersonagem.vida < CriacaoPersonagem.vidaTotal)
            {
                Console.WriteLine($"Você recuperou {potion} pontos de vida");
                Program.matrizinv[Inventario.linha, 0] = null;
                Combates.pode = false;
                CriacaoPersonagem.vida = potion + CriacaoPersonagem.vida; //vida atual
            }
            
        }
        public static void Energetico(string?[,] matrizinv, bool pode)
        {
            Random random = new Random();
            int energetico = 15;
            int chanceMorte = random.Next(1, 11);
            int dano = random.Next(5, 16);
            if (CriacaoPersonagem.mana >= CriacaoPersonagem.manaTotal)
            {
                CriacaoPersonagem.mana = CriacaoPersonagem.manaTotal;
                Console.WriteLine("Tua mana tá cheia, aprendiz mais fraco do chat gpt");
            }
            
            else if (CriacaoPersonagem.mana < CriacaoPersonagem.manaTotal)
            {
                Console.WriteLine($"Você recuperou {energetico} pontos de mana");
                if(chanceMorte <= 3){
                    CriacaoPersonagem.vida -= dano;
                    System.Console.WriteLine("?!");
                    Console.WriteLine($"Você sente um aperto no coração, voce perde {dano}");
                }
                CriacaoPersonagem.mana = energetico + CriacaoPersonagem.mana;
                Combates.pode = false;
                Program.matrizinv[Inventario.linha, 0] = null;
            }
        }
        public static void ItemPassivo(){
            System.Console.WriteLine("Esse item ja e equipado passivamente");
        }
    }
}