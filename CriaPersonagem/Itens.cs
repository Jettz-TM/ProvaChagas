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
            else if(matrizinv[linha - 1, 0] == "Sorvete de Chocolate"){
                Sorvete(Program.matrizinv, Combates.pode);
            }
            
            
        }
        public static void Salgado(string?[,] matrizinv, bool pode)
        {
            int potion = 15;

            if(CriacaoPersonagem.vida == CriacaoPersonagem.vidaTotal){
                Console.WriteLine("Tua vida tá cheia, aprendiz mais fraco do chat gpt");
            }

            else if (CriacaoPersonagem.vida < CriacaoPersonagem.vidaTotal)
            {
                CriacaoPersonagem.vida = potion + CriacaoPersonagem.vida;
                Console.WriteLine($"Você recuperou {potion} pontos de vida");
                if (CriacaoPersonagem.vida >= CriacaoPersonagem.vidaTotal)
            {
                CriacaoPersonagem.vida = CriacaoPersonagem.vidaTotal;
                Console.WriteLine("Tua vida tá cheia");
            }
                Program.matrizinv[Inventario.linha -1, 0] = null;
                Combates.pode = false;
            }
            
        }
        public static void Energetico(string?[,] matrizinv, bool pode)
        {
            Random random = new Random();
            int energetico = 15;
            int chanceMorte = random.Next(1, 11);
            int dano = random.Next(5, 16);
            if(CriacaoPersonagem.mana == CriacaoPersonagem.manaTotal){
                Console.WriteLine("Tua mana tá cheia, aprendiz mais fraco do chat gpt");
            }

            else if (CriacaoPersonagem.mana < CriacaoPersonagem.manaTotal)
            {
                CriacaoPersonagem.mana = energetico + CriacaoPersonagem.mana;
                Console.WriteLine($"Você recuperou {energetico} pontos de mana");
                if (CriacaoPersonagem.mana >= CriacaoPersonagem.manaTotal)
            {
                CriacaoPersonagem.mana = CriacaoPersonagem.manaTotal;
                Console.WriteLine("Tua mana tá cheia");
            }
                if(chanceMorte <= 3){
                    CriacaoPersonagem.vida -= dano;
                    System.Console.WriteLine("?!");
                    Console.WriteLine($"Você sente um aperto no coração, voce perde {dano} pontos de vida");
                }
                Program.matrizinv[Inventario.linha -1, 0] = null;
                Combates.pode = false;
            }
        }
        public static void ItemPassivo(){
            System.Console.WriteLine("Esse item ja e equipado passivamente");
        }
        public static void Sorvete(string?[,] matrizinv, bool pode)
        {
            int potion = 10;
            int energetico = 10;

            if(CriacaoPersonagem.vida == CriacaoPersonagem.vidaTotal && CriacaoPersonagem.mana == CriacaoPersonagem.manaTotal){
                Console.WriteLine("Tua vida e mana estão cheias, cerebro vencido");
            }
            else if (CriacaoPersonagem.vida < CriacaoPersonagem.vidaTotal && CriacaoPersonagem.mana < CriacaoPersonagem.manaTotal)
            {
                CriacaoPersonagem.vida = potion + CriacaoPersonagem.vida;
                CriacaoPersonagem.mana = energetico + CriacaoPersonagem.mana;
                Console.WriteLine($"Você recuperou {potion} pontos de vida e {energetico} pontos de mana");
                if (CriacaoPersonagem.vida >= CriacaoPersonagem.vidaTotal)
            {
                CriacaoPersonagem.vida = CriacaoPersonagem.vidaTotal;
                Console.WriteLine("Tua vida tá cheia");
            }
                if (CriacaoPersonagem.mana >= CriacaoPersonagem.manaTotal)
            {
                CriacaoPersonagem.mana = CriacaoPersonagem.manaTotal;
                Console.WriteLine("Tua mana tá cheia");
            }
                Program.matrizinv[Inventario.linha -1, 0] = null;
                Combates.pode = false;
            }
            
        }
    }
}