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
                Salgado(Program.matrizinv);
            }
            else if(matrizinv[linha - 1, 0] == "Energetico"){
                Energetico(Program.matrizinv);
            }
            else if(matrizinv[linha - 1, 0] == "Soco Inglês"){
                Uniforme();
            }
            else if(matrizinv[linha - 1, 0] == "Uniforme do Interclasse"){
                Ingles();
            }
            
            
        }
        public static void Salgado(string?[,] matrizinv)
        {
            int potion = 15, vidaRecu;

            vidaRecu = potion + CriacaoPersonagem.vida; //vida atual

            if (CriacaoPersonagem.vida < CriacaoPersonagem.vidaTotal)
            {
                Console.WriteLine($"Você recuperou {vidaRecu} pontos de vida");
                Program.matrizinv[Inventario.linha, 0] = null;
            }
            if (CriacaoPersonagem.vida >= CriacaoPersonagem.vidaTotal)
            {
                CriacaoPersonagem.vida = CriacaoPersonagem.vidaTotal;
                Console.WriteLine("Tua vida ta cheia seu jumento");
            }

        }
        public static void Energetico(string?[,] matrizinv)
        {
            Random random = new Random();
            int energetico = 15, manaRecu;
            int chanceMorte = random.Next(1, 11);
            int dano = random.Next(5, 16);

            manaRecu = energetico + CriacaoPersonagem.mana;

            if (CriacaoPersonagem.mana < CriacaoPersonagem.manaTotal)
            {
                Console.WriteLine($"Você recuperou {manaRecu} pontos de mana");
                if(chanceMorte <= 3){
                    CriacaoPersonagem.vida =- dano;
                    System.Console.WriteLine("?!");
                    Console.WriteLine($"Você sente um aperto no coração, voce perde {dano}");
                }
                Program.matrizinv[Inventario.linha, 0] = null;
            }
            if (CriacaoPersonagem.mana >= CriacaoPersonagem.manaTotal)
            {
                CriacaoPersonagem.mana = CriacaoPersonagem.manaTotal;
                Console.WriteLine("Tua mana tá cheia, aprendiz mais fraco do chat gpt");
            }
        }
        public static void Uniforme(){
            System.Console.WriteLine("Esse item ja e equipado passivamente");
        }
        public static void Ingles(){
            System.Console.WriteLine("Esse item ja e equipado passivamente");
        }
    }
}