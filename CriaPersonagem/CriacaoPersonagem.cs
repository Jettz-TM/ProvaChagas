using System;
namespace Jogo
{
    class CriacaoPersonagem
    {
        public static int vida = 50, mana = 25, forca = 0, resist = 0, intel = 0;
        public static string? nome;
        public static void Personagem()
        {
            int escolha = 0, pontos = 5;

            Console.Write("Digite o nome do seu personagem: ");
            nome = Console.ReadLine();

            do
            {
                Console.Clear();

                Console.Write("Qual a sua classe?\n\n1- Membro da Robótica (mais inteligência e força) \n2- Campeão do Interclasse (mais força e resistência) \n3- Gênio do Clash (equilibrado)\n\nEscolha: ");
                int.TryParse(Console.ReadLine(), out escolha);
                //* cada classe dá 3 pontos de atributos pré-definidos
                //* membro da robotica (mago): 2 de inteligencia e 1 de força
                //* campeao do interclasse (dps): 2 de força e 1 de resistencia
                //* genio do clash (equilibrada): 1 de inteligencia, 1 de força e 1 de resistencia

                switch (escolha)
                {
                    case 1:
                        intel += 2;
                        forca++;
                        break;
                    case 2:
                        forca += 2;
                        resist++;
                        break;
                    case 3:
                        forca++;
                        resist++;
                        intel++;
                        break;
                }
            } while (escolha <= 0 || escolha >= 4);

            do
            {
                do
                {
                    Console.Clear();

                    Console.Write($"Você tem {pontos} pontos para distribuir entre:\n\n1- Força  2- Resistência  3- Inteligência\n\nEscolha: ");
                    int.TryParse(Console.ReadLine(), out escolha);

                    switch (escolha)
                    {
                        case 1:
                            forca++; //* aumenta o dano
                            break;
                        case 2:
                            resist++; //* aumenta a vida
                            break;
                        case 3:
                            intel++; //* aumenta a mana
                            break;
                    }
                } while (escolha <= 0 || escolha >= 4);
                pontos--;
            } while (pontos > 0);

            vida += 5 * resist;
            mana += 5 * intel;
        }

    }
}