
using System;
namespace Jogo
{
    class Combates //Classe pra ter os combates guardados (por enquanto só do gpt e do inimigo generico)
    {
        public static void ChatGPT()
        {
            int vidaGPT = 120, dano, acaogpt, escolha, resposta;
            //* dano provisório (por enquanto aumenta com a força, mudar depois)

            Random random = new Random();

            while (vidaGPT > 0)
            {
                acaogpt = random.Next(1, 9); //* decide de forma aleatoria o codigo que o player tem que corrigir
                resposta = random.Next(1, 4); //* decide de forma aleatoria a resposta do codigo

                Console.Clear();

                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida ChatGPT: {vidaGPT}");

                switch (acaogpt)
                {
                    case 1:
                        Console.WriteLine("O que falta no código?\n\nConsole.WriteLine('Olá Mundo!!')\n");
                        switch (resposta)
                        {
                            case 1:
                                Console.Write("1- Falta um ; \n2- Falta {} \n3- Falta []\n\nEscolha: ");
                                break;
                            case 2:
                                Console.Write("1- Falta {} \n2- Falta um ; \n3- Falta []\n\nEscolha: ");
                                break;
                            case 3:
                                Console.Write("1- Falta [] \n2- Falta {} \n3-Falta um ;\n\nEscolha: ");
                                break;
                        }
                        int.TryParse(Console.ReadLine(), out escolha);
                        if (escolha == resposta)
                        {
                            dano = random.Next(1, 16);
                            Console.Write($"Você corrigiu o código e deu {dano + CriacaoPersonagem.forca} de dano!");
                            Console.ReadLine();
                            vidaGPT -= dano + CriacaoPersonagem.forca;
                        }
                        else
                        {
                            dano = random.Next(1, 11);
                            Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                            Console.ReadLine();
                            CriacaoPersonagem.vida -= dano;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Como corrigir o código?\n\nif (i >= 5 or i <= 10) {}\n");
                        switch (resposta)
                        {
                            case 1:
                                Console.Write("1- Trocar o 'or' por '||' \n2- Colocar [] \n3- Colocar um ;\n\nEscolha: ");
                                break;
                            case 2:
                                Console.Write("1- Colocar [] \n2- Trocar o 'or' por '||' \n3- Colocar um ;\n\nEscolha: ");
                                break;
                            case 3:
                                Console.Write("1- Colocar um ; \n2- Colocar [] \n3- Trocar o 'or' por '||'\n\nEscolha: ");
                                break;
                        }
                        int.TryParse(Console.ReadLine(), out escolha);
                        if (escolha == resposta)
                        {
                            dano = random.Next(1, 16);
                            Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                            Console.ReadLine();
                            vidaGPT -= dano + CriacaoPersonagem.forca;
                        }
                        else
                        {
                            dano = random.Next(1, 11);
                            Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                            Console.ReadLine();
                            CriacaoPersonagem.vida -= dano;
                        }
                        break;
                    case 3:
                        Console.WriteLine("O que falta no código?\n\nfor (int i; i <= 10; i++) {}\n");
                        switch (resposta)
                        {
                            case 1:
                                Console.Write("1- Falta o valor de i \n2- Falta um ; \n3- Não deveria ter {}\n\nEscolha: ");
                                break;
                            case 2:
                                Console.Write("1- Não deveria ter {} \n2- Falta o valor de i \n3- Falta um ;\n\nEscolha: ");
                                break;
                            case 3:
                                Console.Write("1- Falta um ; \n2- Não deveria ter {} \n3- Falta o valor de i\n\nEscolha: ");
                                break;
                        }
                        int.TryParse(Console.ReadLine(), out escolha);
                        if (escolha == resposta)
                        {
                            dano = random.Next(1, 16);
                            Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                            Console.ReadLine();
                            vidaGPT -= dano + CriacaoPersonagem.forca;
                        }
                        else
                        {
                            dano = random.Next(1, 11);
                            Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                            Console.ReadLine();
                            CriacaoPersonagem.vida -= dano;
                        }
                        break;
                    case 4:
                        Console.WriteLine("O que falta no código?\n\nstring nome = Bruno;\n");
                        switch (resposta)
                        {
                            case 1:
                                Console.Write("1- 'Bruno' deveria estar entre aspas \n2- Falta {} \n3- Falta ()\n\nEscolha: ");
                                break;
                            case 2:
                                Console.Write("1- Falta () \n2- 'Bruno' deveria estar entre aspas \n3- Falta {}\n\nEscolha: ");
                                break;
                            case 3:
                                Console.Write("1- Falta {} \n2- Falta () \n3- 'Bruno' deveria estar entre aspas\n\nEscolha: ");
                                break;
                        }
                        int.TryParse(Console.ReadLine(), out escolha);
                        if (escolha == resposta)
                        {
                            dano = random.Next(1, 16);
                            Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                            Console.ReadLine();
                            vidaGPT -= dano + CriacaoPersonagem.forca;
                        }
                        else
                        {
                            dano = random.Next(1, 11);
                            Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                            Console.ReadLine();
                            CriacaoPersonagem.vida -= dano;
                        }
                        break;
                    case 5:
                        Console.WriteLine("O que está de errado com o código?\n\nConsole.ReadLine(nome);\n");
                        switch (resposta)
                        {
                            case 1:
                                Console.Write("1- ReadLine não leva parâmetro \n2- Falta {} \n3- Falta []\n\nEscolha: ");
                                break;
                            case 2:
                                Console.Write("1- Falta [] \n2- ReadLine não leva parâmetro \n3- Falta {}\n\nEscolha: ");
                                break;
                            case 3:
                                Console.Write("1- Falta {} \n2- Falta [] \n3- ReadLine não leva parâmetro\n\nEscolha: ");
                                break;
                        }
                        int.TryParse(Console.ReadLine(), out escolha);
                        if (escolha == resposta)
                        {
                            dano = random.Next(1, 16);
                            Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                            Console.ReadLine();
                            vidaGPT -= dano + CriacaoPersonagem.forca;
                        }
                        else
                        {
                            dano = random.Next(1, 11);
                            Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                            Console.ReadLine();
                            CriacaoPersonagem.vida -= dano;
                        }
                        break;
                    case 6:
                        Console.WriteLine("O que está de errado com o código?\n\nint nome;\nnome = Console.ReadLine();\n");
                        switch (resposta)
                        {
                            case 1:
                                Console.Write("1- A variável deveria ser lida com o TryParse \n2- Falta um '=' \n3- Falta {}\n\nEscolha: ");
                                break;
                            case 2:
                                Console.Write("1- Falta um '=' \n2- A variável deveria ser lida com o TryParse \n3- Falta {}\n\nEscolha: ");
                                break;
                            case 3:
                                Console.Write("1- Falta {} \n2- Falta um '=' \n3- A variável deveria ser lida com o TryParse\n\nEscolha: ");
                                break;
                        }
                        int.TryParse(Console.ReadLine(), out escolha);
                        if (escolha == resposta)
                        {
                            dano = random.Next(1, 16);
                            Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                            Console.ReadLine();
                            vidaGPT -= dano + CriacaoPersonagem.forca;
                        }
                        else
                        {
                            dano = random.Next(1, 11);
                            Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                            Console.ReadLine();
                            CriacaoPersonagem.vida -= dano;
                        }
                        break;
                    case 7:
                        Console.WriteLine("O que falta com o código?\n\nConsole.WriteLine('O nome digitado é: {nome}');");
                        switch (resposta)
                        {
                            case 1:
                                Console.Write("1- Falta um '$' \n2- Não deveria ter as chaves \n3- Falta []\n\nEscolha: ");
                                break;
                            case 2:
                                Console.Write("1- Falta [] \n2- Falta um '$' \n3- Não deveria ter as chaves\n\nEscolha: ");
                                break;
                            case 3:
                                Console.Write("1- Não deveria ter as chaves \n2- Falta [] \n3- Falta um '$'\n\nEscolha: ");
                                break;
                        }
                        int.TryParse(Console.ReadLine(), out escolha);
                        if (escolha == resposta)
                        {
                            dano = random.Next(1, 16);
                            Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                            Console.ReadLine();
                            vidaGPT -= dano + CriacaoPersonagem.forca;
                        }
                        else
                        {
                            dano = random.Next(1, 11);
                            Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                            Console.ReadLine();
                            CriacaoPersonagem.vida -= dano;
                        }
                        break;
                    case 8:
                        Console.WriteLine("O que tem de errado no código?\nconst int numero = 1; \nnumero = 2;");
                        switch (resposta)
                        {
                            case 1:
                                Console.Write("1- O valor da constante não muda \n2- Faltou () \n3- Não deveria ter ;\n\nEscolha: ");
                                break;
                            case 2:
                                Console.Write("1- Não deveria ter ; \n2- O valor da constante não muda \n3- Faltou ()\n\nEscolha: ");
                                break;
                            case 3:
                                Console.Write("1- Faltou () \n2- Não deveria ter ; \n3- O valor da constante não muda\n\nEscolha: ");
                                break;
                        }
                        int.TryParse(Console.ReadLine(), out escolha);
                        if (escolha == resposta)
                        {
                            dano = random.Next(1, 16);
                            Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                            Console.ReadLine();
                            vidaGPT -= dano + CriacaoPersonagem.forca;
                        }
                        else
                        {
                            dano = random.Next(1, 11);
                            Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                            Console.ReadLine();
                            CriacaoPersonagem.vida -= dano;
                        }
                        break;
                }
            }
            Console.Clear();
            Console.Write($"Parabéns {CriacaoPersonagem.nome}!! Você ganhou do Chat GPT");
        }

        public static void InimigoGenerico()
        {
            int resist = 0, vidajogador = (50 + 5 * resist), DanoArma = 0, VidaInimigo = 50, manajogador = 50, ataqueinimigo = 15;
            Random random = new Random();

            while (vidajogador > 0 && VidaInimigo > 0)
            {
                bool menu = false;

                int escolha, escolhaluta;
                System.Console.WriteLine("--- Turno do jogador ---");
                System.Console.WriteLine($"Vida: {vidajogador} | Mana: {manajogador}\n Vida do inimigo: {VidaInimigo}");
                System.Console.WriteLine("1 - Atacar\n2 - Ação especial\n3 - Item");
                int.TryParse(Console.ReadLine(), out escolha);

                if (escolha == 1)
                {
                    menu = true;
                    while (menu == true)
                    {
                        System.Console.WriteLine("1 - Chute de bola (10 de dano)\n2 - Jogar EV3 (5 de dano)\n3 - Sair ");
                        int.TryParse(Console.ReadLine(), out escolhaluta);
                        if (escolhaluta == 1)
                        {
                            DanoArma = 15;
                            VidaInimigo -= DanoArma;
                            System.Console.WriteLine($"Você deu {DanoArma} de dano");
                            menu = false;
                        }
                        else if (escolhaluta == 2)
                        {
                            DanoArma = 5;
                            VidaInimigo -= DanoArma;
                            System.Console.WriteLine($"Você deu {DanoArma} de dano");
                            menu = false;
                        }
                        else if (escolhaluta == 3)
                        {
                            menu = false;
                        }
                    }
                }
                else if (escolha == 2)
                {
                    menu = true;
                    while (menu == true)
                    {
                        System.Console.WriteLine("1 - Atacar com o robô (15 de mana)\n2 - Sacrificar um robô(5 de mana)\n3 - Sair ");
                        int.TryParse(Console.ReadLine(), out escolhaluta);
                        if (escolhaluta == 1)
                        {
                            if (manajogador >= 15)
                            {
                                manajogador -= 15;
                                DanoArma = 20;
                                VidaInimigo -= DanoArma;
                                System.Console.WriteLine($"Você deu {DanoArma} de dano");
                                menu = false;
                            }
                            else
                            {
                                System.Console.WriteLine("MANA INSUFICIENTE!");
                                menu = false;
                            }
                        }
                        else if (escolhaluta == 2)
                        {
                            manajogador -= 5;
                            System.Console.WriteLine("Você joga um robô entre você e o inimígo e evita o dano nesse turno");
                            menu = false;
                        }
                        else if (escolhaluta == 3)
                        {
                            menu = false;
                        }


                    }
                }
                if (VidaInimigo > 0)
                {
                    System.Console.WriteLine("--- Turno do inimigo ---");
                    int escolhainimigo = random.Next(0, 2);

                    if (escolhainimigo == 0)
                    {
                        vidajogador -= ataqueinimigo;
                        System.Console.WriteLine($"O inimigo atacou e deu {ataqueinimigo} de dano!");
                    }
                    else
                    {
                        System.Console.WriteLine("O inimigo de protegeu e não tomou dano nesse turno");
                    }
                }
            }
            if (vidajogador > 0)
            {
                System.Console.WriteLine("Você ganhou o combate!");
            }
            else
            {
                System.Console.WriteLine("Você foi derrotado :(");
            }
        }
    }
}