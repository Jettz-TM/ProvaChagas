using System.Media;
using System;
using System.Diagnostics;
namespace Jogo
{
    class Combates //Classe pra ter os combates guardados (por enquanto só do gpt e do inimigo generico)
    {
        public static int morreu, vidaGPT = 120, dano, acaogpt, escolha, resposta, addDinheiro;
        public static bool pode = true;
        public static void ChatGPT()
        {
            morreu = 0;

            string Som = Path.Combine(Program.diretorio, "assets", "caos.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Som);
            player.PlayLooping();
            //* dano provisório (por enquanto aumenta com a força, mudar depois)

            Random random = new Random();

            while (vidaGPT > 0 && CriacaoPersonagem.vida > 0)
            {
                acaogpt = random.Next(1, 17); //* decide de forma aleatoria o codigo que o player tem que corrigir
                resposta = random.Next(1, 4); //* decide de forma aleatoria a resposta do codigo

                Console.Clear();

                switch (acaogpt) //* trabalho do caralho pra fazer funcionar, se alguem mexer eu me mato
                {
                    case 1:
                        PerguntasGPT.Pergunta1(); //* manda a pergunta 1, com a resposta aleatoria
                        break;
                    case 2:
                        PerguntasGPT.Pergunta2(); //* manda a pergunta 2, com a resposta aleatoria
                        break;
                    case 3:
                        PerguntasGPT.Pergunta3(); //* manda a pergunta 3, com a resposta aleatoria
                        break;
                    case 4:
                        PerguntasGPT.Pergunta4(); //* manda a pergunta 4, com a resposta aleatoria
                        break;
                    case 5:
                        PerguntasGPT.Pergunta5(); //* manda a pergunta 5, com a resposta aleatoria
                        break;
                    case 6:
                        PerguntasGPT.Pergunta6(); //* manda a pergunta 6, com a resposta aleatoria
                        break;
                    case 7:
                        PerguntasGPT.Pergunta7(); //* manda a pergunta 7, com a resposta aleatoria
                        break;
                    case 8:
                        PerguntasGPT.Pergunta8(); //* manda a pergunta 8, com a resposta aleatoria
                        break;
                    case 9:
                        PerguntasGPT.Pergunta9();
                        break;
                    case 10:
                        PerguntasGPT.Pergunta10();
                        break;
                    case 11:
                        PerguntasGPT.Pergunta11();
                        break;
                    case 12:
                        PerguntasGPT.Pergunta12();
                        break;
                    case 13:
                        PerguntasGPT.Pergunta13();
                        break;
                    case 14:
                        PerguntasGPT.Pergunta14();
                        break;
                    case 15:
                        PerguntasGPT.Pergunta15();
                        break;
                    case 16:
                        PerguntasGPT.Pergunta16();
                        break;
                }
            }
            player.Stop();
            Console.Clear();
            if (CriacaoPersonagem.vida <= 0)
            {
                Console.WriteLine("Parabéns, você morreu.");
                Console.ReadKey();
                Console.WriteLine("\nChat GPT: Evidencia-se uma notável carência de habilidade em suas ações");
                Console.ReadKey();
                Console.WriteLine("Chagas: Skill Issue");
                Console.ReadKey();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\nDeseja recomeçar?");
                    Console.Write("\n1- Sim   2- Não\n\nEscolha: ");
                    if (!int.TryParse(Console.ReadLine(), out morreu) || morreu < 1 || morreu > 2)
                    {
                        Console.WriteLine("Digite uma opção válida");
                        Console.ReadKey();
                    }
                    if (Combates.morreu == 1)
                    {
                        string build = Path.Combine(Program.diretorio, "CriaPersonagem.exe");
                        Process.Start(build);
                        Environment.Exit(0);
                        break;
                    }
                    else if (Combates.morreu == 2)
                    {
                        Environment.Exit(0);
                        break;
                    }
                }
            }
            else
            {
                Console.Clear();
                CriacaoPersonagem.dinheiro +=  addDinheiro = random.Next(5, 16);
                Console.WriteLine($"Parabéns {CriacaoPersonagem.nome}, você ganhou do Chat GPT!");
                Console.ReadKey();
                Console.WriteLine($"Você ganhou {addDinheiro} de dinheiro!");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Chagas: O Chat GPT perdeu, esse paia!\n*Chagas sai com raiva*");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void InimigoGenerico()
        {
            string gen1 = Path.Combine(Program.diretorio, "assets", "generico.wav");
            System.Media.SoundPlayer gen = new System.Media.SoundPlayer(gen1);
            gen.PlayLooping();
            int vidaTotalInimigo = 50;
            Random random = new Random();
            bool bloqueio = false;


            while (CriacaoPersonagem.vida > 0 && vidaTotalInimigo > 0)
            {
                int dant = 0;
                if (CriacaoPersonagem.vida <= 0)
                {
                    break;
                }
                int danoPlayer = random.Next(5, 21), danoMurro = random.Next(1, 11) + CriacaoPersonagem.buffArma, ataqueinimigo = random.Next(1, 19);
                ataqueinimigo = random.Next(5, 26);
                int menu = 0, escolha, escolhaluta;
                if (menu == 0)
                {
                    pode = true;
                    bloqueio = false;
                    System.Console.WriteLine("--- Turno do jogador ---");
                    System.Console.WriteLine($"Vida: {CriacaoPersonagem.vida} | Mana: {CriacaoPersonagem.mana}\n Vida do inimigo: {vidaTotalInimigo}");
                    System.Console.WriteLine("1 - Atacar\n2 - Ação especial\n3 - Item");
                }
                int.TryParse(Console.ReadLine(), out escolha);
                if (escolha == 1)
                {
                    menu = 1;
                    while (menu == 1)
                    {
                        Console.Clear();
                        System.Console.WriteLine("1 - Murro\n2 - Sair ");
                        int.TryParse(Console.ReadLine(), out escolhaluta);
                        if (escolhaluta == 1)
                        {
                            System.Console.WriteLine($"Você deu {danoMurro + CriacaoPersonagem.forca} de dano");
                            dant = 1;
                            menu = 4;
                        }
                        else if (escolhaluta == 2)
                        {
                            menu = 0;
                        }
                    }
                }
                else if (escolha == 2)
                {
                    menu = 2;
                    while (menu == 2)
                    {
                        Console.Clear();
                        switch (CriacaoPersonagem.classe)
                        {
                            case 1:
                                System.Console.WriteLine("1 - Atacar com o robô (15 de mana)\n2 - Sacrificar um robô(5 de mana)\n3 - Sair ");
                                int.TryParse(Console.ReadLine(), out escolhaluta);
                                if (escolhaluta == 1)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 15;
                                        System.Console.WriteLine($"Você deu {danoPlayer + CriacaoPersonagem.forca} de dano");
                                        dant = 2;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 2)
                                {
                                    if (CriacaoPersonagem.mana >= 5)
                                    {
                                        CriacaoPersonagem.mana -= 5;
                                        System.Console.WriteLine("Você joga um robô entre você e o inimígo e evita o dano nesse turno");
                                        bloqueio = true;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }

                                }
                                else if (escolhaluta == 3)
                                {
                                    menu = 0;
                                }
                                break;
                            case 2:
                                System.Console.WriteLine("1 - Chute Futebolístico (15 de mana)\n2 - Falta (5 de mana)\n3 - Sair ");
                                int.TryParse(Console.ReadLine(), out escolhaluta);
                                if (escolhaluta == 1)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 15;
                                        System.Console.WriteLine($"Você deu {danoPlayer + CriacaoPersonagem.forca} de dano");
                                        dant = 2;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 2)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 5;
                                        System.Console.WriteLine("Você cobra falta e muda a direção do ataque pro lado");
                                        bloqueio = true;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }

                                }
                                else if (escolhaluta == 3)
                                {
                                    menu = 0;
                                }
                                break;
                            case 3:
                                System.Console.WriteLine("1 - Cavaleiro Nível 15 (15 de mana)\n2 - Roubar Elixir (5 de mana)\n3 - Sair ");
                                int.TryParse(Console.ReadLine(), out escolhaluta);
                                if (escolhaluta == 1)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 15;
                                        System.Console.WriteLine($"Você deu {danoPlayer + CriacaoPersonagem.forca} de dano");
                                        dant = 2;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 2)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 5;
                                        System.Console.WriteLine("Você rouba o elixir do inimigo e ele não consegue atacar nesse turno");
                                        bloqueio = true;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 3)
                                {
                                    menu = 0;
                                }
                                break;
                        }

                    }
                }
                else if (escolha == 3)
                {
                    Console.Clear();
                    while (Combates.pode)
                    {
                        System.Console.WriteLine("--- Escolha um item ---\nDigite 0 para voltar");
                        Inventario.ShowInv(Program.matrizinv);
                        if (!int.TryParse(Console.ReadLine(), out Inventario.linha) || Inventario.linha > 9 || Inventario.linha <= -1)
                        {
                            Console.Clear();
                            System.Console.WriteLine("Escolha uma opção valida");
                        }
                        else if (Inventario.linha == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Itens.Acess(Program.matrizinv, Inventario.linha);
                            Console.ReadKey();
                            menu = 4;
                        }
                    }
                }
                int escolhainimigo = random.Next(0, 2);
                if (escolhainimigo == 0)
                {
                    if (dant == 1)
                    {
                        vidaTotalInimigo -= danoMurro + CriacaoPersonagem.forca;
                    }
                    else if (dant == 2)
                    {
                        vidaTotalInimigo -= danoPlayer + CriacaoPersonagem.forca;
                    }
                }
                if (vidaTotalInimigo > 0 && menu == 4)
                {
                    System.Console.WriteLine("--- Turno do inimigo ---");

                    if (escolhainimigo == 0)
                    {
                        if (bloqueio == false)
                        {
                            CriacaoPersonagem.vida -= ataqueinimigo - CriacaoPersonagem.buffArmadura;
                            System.Console.WriteLine($"O inimigo atacou e deu {ataqueinimigo - CriacaoPersonagem.buffArmadura} de dano!");
                        }
                        else if (bloqueio == true)
                        {
                            System.Console.WriteLine($"O inimigo tentou atacar mas falhou :(");
                        }
                    }
                    else if (escolhainimigo == 1)
                    {
                        System.Console.WriteLine("O inimigo de protegeu e não tomou dano nesse turno");
                    }
                }
            }
            if (CriacaoPersonagem.vida > 0 && vidaTotalInimigo <= 0)
            {
                Console.Clear();
                CriacaoPersonagem.dinheiro += addDinheiro = random.Next(5, 16);
                System.Console.WriteLine($"Você ganhou o combate {CriacaoPersonagem.nome}!");
                Console.ReadKey();
                Console.WriteLine($"Você ganhou {addDinheiro} de dinheiro!");
                Console.ReadKey();
                gen.Stop();
            }
            else if (CriacaoPersonagem.vida <= 0 && vidaTotalInimigo >= 0)
            {
                Console.Clear();
                gen.Stop();
                System.Console.WriteLine("Você foi derrotado :(");
                Console.ReadKey();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\nDeseja recomeçar?");
                    Console.Write("\n1- Sim   2- Não\n\nEscolha: ");
                    if (!int.TryParse(Console.ReadLine(), out morreu) || morreu < 1 || morreu > 2)
                    {
                        Console.WriteLine("Digite uma opção válida");
                        Console.ReadKey();
                    }
                    if (Combates.morreu == 1)
                    {
                        string build = Path.Combine(Program.diretorio, "CriaPersonagem.exe");
                        Process.Start(build);
                        Environment.Exit(0);
                        break;
                    }
                    else if (Combates.morreu == 2)
                    {
                        Environment.Exit(0);
                        break;
                    }
                }
            }
        }

        public static void Lista5()
        {
            string gen1 = Path.Combine(Program.diretorio, "assets", "generico.wav");
            System.Media.SoundPlayer gen = new System.Media.SoundPlayer(gen1);
            gen.PlayLooping();
            int vidaTotalInimigo = 80;
            Random random = new Random();
            bool bloqueio = false;


            while (CriacaoPersonagem.vida > 0 && vidaTotalInimigo > 0)
            {
                int dant = 0;
                if (CriacaoPersonagem.vida <= 0)
                {
                    break;
                }
                int danoPlayer = random.Next(5, 21), danoMurro = random.Next(1, 11) + CriacaoPersonagem.buffArma,
                ataqueinimigo = random.Next(5, 26);
                int menu = 0, escolha, escolhaluta;
                if (menu == 0)
                {
                    pode = true;
                    bloqueio = false;
                    System.Console.WriteLine("--- Turno do jogador ---");
                    System.Console.WriteLine($"Vida: {CriacaoPersonagem.vida} | Mana: {CriacaoPersonagem.mana}\n Vida do inimigo: {vidaTotalInimigo}");
                    System.Console.WriteLine("1 - Atacar\n2 - Ação especial\n3 - Item");
                }
                int.TryParse(Console.ReadLine(), out escolha);
                if (escolha == 1)
                {
                    menu = 1;
                    while (menu == 1)
                    {
                        Console.Clear();
                        System.Console.WriteLine("1 - Murro\n2 - Sair ");
                        int.TryParse(Console.ReadLine(), out escolhaluta);
                        if (escolhaluta == 1)
                        {
                            System.Console.WriteLine($"Você deu {danoMurro + CriacaoPersonagem.forca} de dano");
                            dant = 1;
                            menu = 4;
                        }
                        else if (escolhaluta == 2)
                        {
                            menu = 0;
                        }
                    }
                }
                else if (escolha == 2)
                {
                    menu = 2;
                    while (menu == 2)
                    {
                        Console.Clear();
                        switch (CriacaoPersonagem.classe)
                        {
                            case 1:
                                System.Console.WriteLine("1 - Atacar com o robô (15 de mana)\n2 - Sacrificar um robô(5 de mana)\n3 - Sair ");
                                int.TryParse(Console.ReadLine(), out escolhaluta);
                                if (escolhaluta == 1)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 15;
                                        System.Console.WriteLine($"Você deu {danoPlayer + CriacaoPersonagem.forca} de dano");
                                        dant = 2;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 2)
                                {
                                    if (CriacaoPersonagem.mana >= 5)
                                    {
                                        CriacaoPersonagem.mana -= 5;
                                        System.Console.WriteLine("Você joga um robô entre você e o inimígo e evita o dano nesse turno");
                                        bloqueio = true;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }

                                }
                                else if (escolhaluta == 3)
                                {
                                    menu = 0;
                                }
                                break;
                            case 2:
                                System.Console.WriteLine("1 - Chute Futebolístico (15 de mana)\n2 - Falta (5 de mana)\n3 - Sair ");
                                int.TryParse(Console.ReadLine(), out escolhaluta);
                                if (escolhaluta == 1)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 15;
                                        System.Console.WriteLine($"Você deu {danoPlayer + CriacaoPersonagem.forca} de dano");
                                        dant = 2;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 2)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 5;
                                        System.Console.WriteLine("Você cobra falta e muda a direção do ataque pro lado");
                                        bloqueio = true;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }

                                }
                                else if (escolhaluta == 3)
                                {
                                    menu = 0;
                                }
                                break;
                            case 3:
                                System.Console.WriteLine("1 - Cavaleiro Nível 15 (15 de mana)\n2 - Roubar Elixir (5 de mana)\n3 - Sair ");
                                int.TryParse(Console.ReadLine(), out escolhaluta);
                                if (escolhaluta == 1)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 15;
                                        System.Console.WriteLine($"Você deu {danoPlayer + CriacaoPersonagem.forca} de dano");
                                        dant = 2;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 2)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 5;
                                        System.Console.WriteLine("Você rouba o elixir do inimigo e ele não consegue atacar nesse turno");
                                        bloqueio = true;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 3)
                                {
                                    menu = 0;
                                }
                                break;
                        }

                    }
                }
                else if (escolha == 3)
                {
                    Console.Clear();
                    while (Combates.pode)
                    {
                        System.Console.WriteLine("--- Escolha um item ---\nDigite 0 para voltar");
                        Inventario.ShowInv(Program.matrizinv);
                        if (!int.TryParse(Console.ReadLine(), out Inventario.linha) || Inventario.linha > 9 || Inventario.linha <= -1)
                        {
                            Console.Clear();
                            System.Console.WriteLine("Escolha uma opção valida");
                        }
                        else if (Inventario.linha == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Itens.Acess(Program.matrizinv, Inventario.linha);
                            Console.ReadKey();
                            menu = 4;
                        }
                    }
                }
                int escolhainimigo = random.Next(0, 2);
                if (escolhainimigo == 0)
                {
                    if (dant == 1)
                    {
                        vidaTotalInimigo -= danoMurro + CriacaoPersonagem.forca;
                    }
                    else if (dant == 2)
                    {
                        vidaTotalInimigo -= danoPlayer + CriacaoPersonagem.forca;
                    }
                }
                if (vidaTotalInimigo > 0 && menu == 4)
                {
                    System.Console.WriteLine("--- Turno do inimigo ---");

                    if (escolhainimigo == 0)
                    {
                        if (bloqueio == false)
                        {
                            if(ataqueinimigo < CriacaoPersonagem.buffArmadura){
                                System.Console.WriteLine($"O inimigo atacou e deu 0 de dano!");
                            }
                            else{
                                System.Console.WriteLine($"O inimigo atacou e deu {ataqueinimigo - CriacaoPersonagem.buffArmadura} de dano!");
                                CriacaoPersonagem.vida -= ataqueinimigo - CriacaoPersonagem.buffArmadura;

                            }
                        }
                        else if (bloqueio == true)
                        {
                            System.Console.WriteLine($"O inimigo tentou atacar mas falhou :(");
                        }
                    }
                    else if (escolhainimigo == 1)
                    {
                        System.Console.WriteLine("O inimigo de protegeu e não tomou dano nesse turno");
                    }
                }
            }
            if (CriacaoPersonagem.vida > 0 && vidaTotalInimigo <= 0)
            {
                Console.Clear();
                CriacaoPersonagem.dinheiro += addDinheiro = random.Next(10, 26);
                System.Console.WriteLine($"Você ganhou o combate {CriacaoPersonagem.nome}!");
                Console.ReadKey();
                Console.WriteLine($"Você ganhou {addDinheiro} de dinheiro!");
                Console.ReadKey();
                gen.Stop();
            }
            else if (CriacaoPersonagem.vida <= 0 && vidaTotalInimigo >= 0)
            {
                Console.Clear();
                gen.Stop();
                System.Console.WriteLine("Você foi derrotado :(");
                Console.ReadKey();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\nDeseja recomeçar?");
                    Console.Write("\n1- Sim   2- Não\n\nEscolha: ");
                    if (!int.TryParse(Console.ReadLine(), out morreu) || morreu < 1 || morreu > 2)
                    {
                        Console.WriteLine("Digite uma opção válida");
                        Console.ReadKey();
                    }
                    if (Combates.morreu == 1)
                    {
                        string build = Path.Combine(Program.diretorio, "CriaPersonagem.exe");
                        Process.Start(build);
                        Environment.Exit(0);
                        break;
                    }
                    else if (Combates.morreu == 2)
                    {
                        Environment.Exit(0);
                        break;
                    }
                }
            }
        }


        public static void Chagas()
        {
            string gen1 = Path.Combine(Program.diretorio, "assets", "generico.wav");
            System.Media.SoundPlayer gen = new System.Media.SoundPlayer(gen1);
            gen.PlayLooping();
            int vidaTotalInimigo = 160;
            Random random = new Random();
            bool bloqueio = false;


            while (CriacaoPersonagem.vida > 0 && vidaTotalInimigo > 0)
            {
                int dant = 0;
                if (CriacaoPersonagem.vida <= 0)
                {
                    break;
                }
                int danoPlayer = random.Next(5, 21), danoMurro = random.Next(1, 11) + CriacaoPersonagem.buffArma,
                ataqueinimigo = random.Next(5, 21);
                int menu = 0, escolha, escolhaluta;
                if (menu == 0)
                {
                    pode = true;
                    bloqueio = false;
                    System.Console.WriteLine("--- Turno do jogador ---");
                    System.Console.WriteLine($"Vida: {CriacaoPersonagem.vida} | Mana: {CriacaoPersonagem.mana}\n Vida do inimigo: {vidaTotalInimigo}");
                    System.Console.WriteLine("1 - Atacar\n2 - Ação especial\n3 - Item");
                }
                int.TryParse(Console.ReadLine(), out escolha);
                if (escolha == 1)
                {
                    menu = 1;
                    while (menu == 1)
                    {
                        Console.Clear();
                        System.Console.WriteLine("1 - Murro\n2 - Sair ");
                        int.TryParse(Console.ReadLine(), out escolhaluta);
                        if (escolhaluta == 1)
                        {
                            System.Console.WriteLine($"Você deu {danoMurro + CriacaoPersonagem.forca} de dano");
                            dant = 1;
                            menu = 4;
                        }
                        else if (escolhaluta == 2)
                        {
                            menu = 0;
                        }
                    }
                }
                else if (escolha == 2)
                {
                    menu = 2;
                    while (menu == 2)
                    {
                        Console.Clear();
                        switch (CriacaoPersonagem.classe)
                        {
                            case 1:
                                System.Console.WriteLine("1 - Atacar com o robô (15 de mana)\n2 - Sacrificar um robô(5 de mana)\n3 - Sair ");
                                int.TryParse(Console.ReadLine(), out escolhaluta);
                                if (escolhaluta == 1)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 15;
                                        System.Console.WriteLine($"Você deu {danoPlayer + CriacaoPersonagem.forca} de dano");
                                        dant = 2;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 2)
                                {
                                    if (CriacaoPersonagem.mana >= 5)
                                    {
                                        CriacaoPersonagem.mana -= 5;
                                        System.Console.WriteLine("Você joga um robô entre você e o inimígo e evita o dano nesse turno");
                                        bloqueio = true;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }

                                }
                                else if (escolhaluta == 3)
                                {
                                    menu = 0;
                                }
                                break;
                            case 2:
                                System.Console.WriteLine("1 - Chute Futebolístico (15 de mana)\n2 - Falta (5 de mana)\n3 - Sair ");
                                int.TryParse(Console.ReadLine(), out escolhaluta);
                                if (escolhaluta == 1)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 15;
                                        System.Console.WriteLine($"Você deu {danoPlayer + CriacaoPersonagem.forca} de dano");
                                        dant = 2;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 2)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 5;
                                        System.Console.WriteLine("Você cobra falta e muda a direção do ataque pro lado");
                                        bloqueio = true;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }

                                }
                                else if (escolhaluta == 3)
                                {
                                    menu = 0;
                                }
                                break;
                            case 3:
                                System.Console.WriteLine("1 - Cavaleiro Nível 15 (15 de mana)\n2 - Roubar Elixir (5 de mana)\n3 - Sair ");
                                int.TryParse(Console.ReadLine(), out escolhaluta);
                                if (escolhaluta == 1)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 15;
                                        System.Console.WriteLine($"Você deu {danoPlayer + CriacaoPersonagem.forca} de dano");
                                        dant = 2;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 2)
                                {
                                    if (CriacaoPersonagem.mana >= 15)
                                    {
                                        CriacaoPersonagem.mana -= 5;
                                        System.Console.WriteLine("Você rouba o elixir do inimigo e ele não consegue atacar nesse turno");
                                        bloqueio = true;
                                        menu = 4;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("MANA INSUFICIENTE!");
                                        menu = 0;
                                    }
                                }
                                else if (escolhaluta == 3)
                                {
                                    menu = 0;
                                }
                                break;
                        }

                    }
                }
                else if (escolha == 3)
                {
                    Console.Clear();
                    while (Combates.pode)
                    {
                        System.Console.WriteLine("--- Escolha um item ---\nDigite 0 para voltar");
                        Inventario.ShowInv(Program.matrizinv);
                        if (!int.TryParse(Console.ReadLine(), out Inventario.linha) || Inventario.linha > 9 || Inventario.linha <= -1)
                        {
                            Console.Clear();
                            System.Console.WriteLine("Escolha uma opção valida");
                        }
                        else if (Inventario.linha == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Itens.Acess(Program.matrizinv, Inventario.linha);
                            Console.ReadKey();
                            menu = 4;
                        }
                    }
                }
                int escolhainimigo = random.Next(0, 2);
                if (escolhainimigo == 0)
                {
                    if (dant == 1)
                    {
                        vidaTotalInimigo -= danoMurro + CriacaoPersonagem.forca;
                    }
                    else if (dant == 2)
                    {
                        vidaTotalInimigo -= danoPlayer + CriacaoPersonagem.forca;
                    }
                }
                if (vidaTotalInimigo > 0 && menu == 4)
                {
                    System.Console.WriteLine("--- Turno do inimigo ---");

                    if (escolhainimigo == 0)
                    {
                        if (bloqueio == false)
                        {
                            if(ataqueinimigo < CriacaoPersonagem.buffArmadura){
                                System.Console.WriteLine($"O inimigo atacou e deu 0 de dano!");
                            }
                            else{
                                System.Console.WriteLine($"O inimigo atacou e deu {ataqueinimigo - CriacaoPersonagem.buffArmadura} de dano!");
                                CriacaoPersonagem.vida -= ataqueinimigo - CriacaoPersonagem.buffArmadura;

                            }
                        }
                        else if (bloqueio == true)
                        {
                            System.Console.WriteLine($"O inimigo tentou atacar mas falhou :(");
                        }
                    }
                    else if (escolhainimigo == 1)
                    {
                        System.Console.WriteLine("O inimigo de protegeu e não tomou dano nesse turno");
                    }
                }
            }
            if (CriacaoPersonagem.vida > 0 && vidaTotalInimigo <= 0)
            {
                Console.Clear();
                CriacaoPersonagem.dinheiro += addDinheiro = random.Next(20, 36);
                System.Console.WriteLine($"Você ganhou o combate {CriacaoPersonagem.nome}!");
                Console.ReadKey();
                Console.WriteLine($"Você ganhou {addDinheiro} de dinheiro!");
                Console.ReadKey();
                gen.Stop();
            }
            else if (CriacaoPersonagem.vida <= 0 && vidaTotalInimigo >= 0)
            {
                Console.Clear();
                gen.Stop();
                System.Console.WriteLine("Você foi derrotado :(");
                Console.ReadKey();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\nDeseja recomeçar?");
                    Console.Write("\n1- Sim   2- Não\n\nEscolha: ");
                    if (!int.TryParse(Console.ReadLine(), out morreu) || morreu < 1 || morreu > 2)
                    {
                        Console.WriteLine("Digite uma opção válida");
                        Console.ReadKey();
                    }
                    if (Combates.morreu == 1)
                    {
                        string build = Path.Combine(Program.diretorio, "CriaPersonagem.exe");
                        Process.Start(build);
                        Environment.Exit(0);
                        break;
                    }
                    else if (Combates.morreu == 2)
                    {
                        Environment.Exit(0);
                        break;
                    }
                }
            }
        }
    }
}