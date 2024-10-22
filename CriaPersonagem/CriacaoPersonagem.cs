using System;
using System.Media;
namespace Jogo
{
    class CriacaoPersonagem
    {
        public static int vidaTotal = 50, manaTotal = 25, forca = 0, resist = 0, intel = 0, classe = 0, vida = 0, mana, buffArma = 0, buffArmadura = 0, dinheiro = 25;
        public static string? nome;
        public static void Personagem()
        {
            string Som = Path.Combine(Program.diretorio, "assets", "criando.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Som);
            player.PlayLooping();


            int escolha = 0, pontos = 5;

            Console.Clear();
            Console.Write("Digite o nome do seu personagem: ");
            nome = Console.ReadLine();

            do
            {
                Console.Clear();

                Console.Write("Qual a sua classe?\n\n1- Membro da Robótica (mais inteligência e força) \n2- Campeão do Interclasse (mais força e resistência) \n3- Gênio do Clash (equilibrado)\n\nEscolha: ");
                //* cada classe dá 3 pontos de atributos pré-definidos
                //* membro da robotica (mago): 2 de inteligencia e 1 de força
                //* campeao do interclasse (dps): 2 de força e 1 de resistencia
                //* genio do clash (equilibrada): 1 de inteligencia, 1 de força e 1 de resistencia
                if (!int.TryParse(Console.ReadLine(), out escolha))
                {
                    System.Console.WriteLine("Digite um valor válido");
                }
                else
                {
                    switch (escolha)
                    {
                        case 1:
                            intel += 2;
                            forca++;
                            classe = 1;
                            break;
                        case 2:
                            forca += 2;
                            resist++;
                            classe = 2;
                            break;
                        case 3:
                            forca++;
                            resist++;
                            intel++;
                            classe = 3;
                            break;
                    }
                }
            } while (escolha <= 0 || escolha >= 4);

            do
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine($"Você tem {pontos} pontos para distribuir entre:");
                    Console.WriteLine("   (Pontos aumentam os seus atributos)");
                    Console.WriteLine($"\n1- Força (Aumenta o dano)\n   Quantidade de pontos no atributo: {forca}");
                    Console.WriteLine($"\n2- Resistência (Aumenta a vidaTotal)\n   Quantidade de pontos no atributo: {resist}");
                    Console.WriteLine($"\n3- Inteligência (Aumenta a mana)\n   Quantidade de pontos no atributo: {intel}");
                    Console.Write("\nEscolha: ");
                    int.TryParse(Console.ReadLine(), out escolha);

                    switch (escolha)
                    {
                        case 1:
                            forca++; //* aumenta o dano
                            break;
                        case 2:
                            resist++; //* aumenta a vidaTotal
                            break;
                        case 3:
                            intel++; //* aumenta a mana
                            break;
                    }
                } while (escolha <= 0 || escolha >= 4);
                pontos--;
            } while (pontos > 0);

            vidaTotal += 5 * resist;
            vida = vidaTotal;
            manaTotal += 5 * intel;
            mana = manaTotal;
            Console.Clear();
            System.Console.WriteLine($"{vidaTotal} de vida total, {manaTotal} de mana total, {forca} de força\nque isso ajude em sua jornada.");
            Console.ReadKey();
            Console.Clear();
            player.Stop();
        }

    }
}
