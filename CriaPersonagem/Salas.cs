using System;
using System.ComponentModel.DataAnnotations;
using System.Media;
namespace Jogo
{
    class Salas
    {
        public static int wins = 0;
        public static int loses = 0;
        public static bool pegouTetano = false;
        public static void Introdução()
        {
            Console.WriteLine("Fortaleza, CE\n");
            Console.ReadKey();
            Console.WriteLine("Segunda-feira, as 3:33 da manhã você recebe uma mensagem do professor Jardel");
            Console.ReadKey();
            Console.WriteLine($"Jardel:{Program.nome} preciso de sua ajuda! O professor Chagas enloqueceu!");
            Console.ReadKey();
            Console.WriteLine("Chagas transformou os alunos em algum tipo de coisa mostruosa através do ChatGPT.");
            Console.ReadKey();
            Console.WriteLine("Preciso de sua ajuda imediatamente, venha rápido até o SENAI, estou na sala J2");
            Console.ReadKey();
            System.Console.WriteLine("*Você se prepara e sai para ajudar o Jardel com essa situação*");
            Console.ReadKey();
            Console.Clear();

        }
        public static void Sala1()
        {
            string item = "Soco Inglês";
            CriacaoPersonagem.buffArma = 5;
            Console.WriteLine("*Você chega no SENAI, é uma situação crítica, tudo parece corrompido e estranho*");
            Console.ReadKey();
            Console.WriteLine("*Nada parece fazer sentido, mas sem raciocinar muito, você chega na sala do Jardel*");
            Console.ReadKey();
            Console.WriteLine("Jardel: Finalmente você chegou!");
            Console.ReadKey();
            Console.WriteLine("Jardel: Agora nos resta enfrentar o Chagas e os alunos");
            Console.ReadKey();
            Console.WriteLine($"Jardel: {CriacaoPersonagem.nome} pegue este soco inglês e enfrente quem estiver no caminho");
            Console.ReadKey();
            Console.Clear();
            Inventario.ChangeInv(Program.matrizinv, item);
            Inventario.ShowInv(Program.matrizinv);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nJardel: Lembre-se que pode haver lojinhas espalhadas pelo colégio");
            Console.ReadKey();
            System.Console.WriteLine("*Você sai da sala do Jardel*");
            Console.ReadKey();
        }
        public static void Sala2()
        {
            string Som = Path.Combine(Program.diretorio, "assets", "infectados.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Som);
            Console.Clear();
            System.Console.WriteLine("*Você chega do lado de fora da sala do Jardel e se depara com um Aluno corrompido*");
            Console.ReadKey();
            player.PlayLooping();
            Console.WriteLine("Aluno transformado: V0c3 s0 p455ará s3 m3us c0dig05 corromperem!");
            Console.ReadKey();
            Console.WriteLine($"{CriacaoPersonagem.nome}: O professor acabou de me avisar sobre a infecção... como isso se agravou tanto?");
            Console.ReadKey();
            System.Console.WriteLine("Aluno transformado: 01110011\n01100101\n00100000\n01101101\n01100001\n01110100\n01100001");
            ////tradução: se mata
            Console.ReadKey();
            Console.Clear();
            Combates.InimigoGenerico();
            player.Stop();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Isso foi muito estranho... Enfim, tem uma saída aqui, é melhor eu seguir por este caminho.");
            Console.ReadKey();
            System.Console.WriteLine("*Você avança para a próxima sala*");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Sala3()
        {
            string Som = Path.Combine(Program.diretorio, "assets", "gambler.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Som);
            player.PlayLooping();
            string? aw;
            System.Console.WriteLine("*Você chega, entra na sala e se depara com várias máquinas caça-níqueis*");
            Console.ReadKey();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Apostas! Meu passa tempo favorito");
            Console.ReadKey();
            Console.Clear();
            while (true)
            {
                Console.ForegroundColor = System.ConsoleColor.Green;
                Random random = new Random();
                int gambler = random.Next(1, 5);
                int gambler2 = random.Next(1, 5);
                int gambler3 = random.Next(1, 5);
                System.Console.WriteLine("Você aposta R$3, se conseguir ganhar, sua grana dobra, se perder, bom, apostas né? rsrs");
                Console.WriteLine($"Número de Vitórias: {wins}");
                Console.WriteLine($"Número de Derrotas: {loses}");
                Console.WriteLine($"Quanto você tem: R${CriacaoPersonagem.dinheiro}");
                Console.WriteLine("\nQuer apostar? \n s - Sim     n - Não");
                aw = Console.ReadLine();
                if (CriacaoPersonagem.dinheiro >= 3 && aw == "s")
                {
                    CriacaoPersonagem.dinheiro = CriacaoPersonagem.dinheiro - 3;
                    Console.WriteLine("Vamoo!");
                    if (gambler == gambler2 && gambler2 == gambler3)
                    {

                        Thread.Sleep(500);
                        Console.Write($"{gambler} ");
                        Thread.Sleep(500);
                        Console.Write($"{gambler2} ");
                        Thread.Sleep(500);
                        Console.WriteLine($"{gambler3}");
                        Thread.Sleep(500);
                        Console.WriteLine("Jackpot!!!!");
                        Thread.Sleep(1000);
                        CriacaoPersonagem.dinheiro = CriacaoPersonagem.dinheiro * 2;
                        wins++;
                        Console.Clear();
                    }
                    else
                    {
                        Thread.Sleep(500);
                        Console.Write($"{gambler} ");
                        Thread.Sleep(500);
                        Console.Write($"{gambler2} ");
                        Thread.Sleep(500);
                        Console.WriteLine($"{gambler3}");
                        Thread.Sleep(500);
                        Console.ForegroundColor = System.ConsoleColor.Red;
                        Console.WriteLine("Droga...");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        loses++; // ++ Aumenta em mais 1, e o +=(x) Aumenta em (x)
                        Console.Clear();
                    }
                }
                else if (aw == "n")
                {
                    Console.ResetColor();
                    Console.Clear();
                    System.Console.WriteLine($"{CriacaoPersonagem.nome}: bom, fica pra outro dia");
                    Console.ReadKey();
                    System.Console.WriteLine($"*Você vai para a próxima sala*");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else if (aw == "s" && CriacaoPersonagem.dinheiro < 3)
                {
                    Console.Clear();
                    System.Console.WriteLine("Acabou seu dinheiro rsrs");
                }
                else
                {
                    Console.Clear();
                    System.Console.WriteLine("Digite um valor válido");
                }
            }
            player.Stop();
        }
        public static void Sala4()
        {
            string Som = Path.Combine(Program.diretorio, "assets", "interludio.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Som);
            player.PlayLooping();
            int escolha;
            bool passo = true;
            System.Console.WriteLine("*Você chega numa sala convenientemente confortável, tem um bebedouro aqui*");
            Console.ReadKey();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Ah meu Deus, uma sala convenientemente confortável!");
            Console.ReadKey();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Acho que eu consigo usar ela para descansar e me hidratar.");
            Console.ReadKey();
            while (passo)
            {
                System.Console.Write("\nO que quer fazer??\n\n1 - Descansar   2 - Beber Água   3 - Sair\n\nEscolha: ");
                int.TryParse(Console.ReadLine(), out escolha);
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Você deita e dorme, mesmo o com o ChatGPT corrompendo tudo na tua volta");
                        Console.ReadKey();
                        CriacaoPersonagem.vida += 25;
                        if (CriacaoPersonagem.vida > CriacaoPersonagem.vidaTotal){
                            CriacaoPersonagem.vida = CriacaoPersonagem.vidaTotal;
                        }
                        Console.WriteLine($"Você cura 25 de vida.\nsua vida atual é de {CriacaoPersonagem.vida}");
                        Console.ReadKey();
                        Console.WriteLine("Tu se prepara e vai desGPTizar o ChatGPT");
                        Console.ReadKey();
                        Console.Clear();
                        passo = false;
                        break;
                    case 2:
                        Console.WriteLine("Você bebe água pra queimar os circuitos do ChatGPT");
                        Console.ReadKey();
                        CriacaoPersonagem.mana += 10;
                        if(CriacaoPersonagem.mana > CriacaoPersonagem.manaTotal){
                            CriacaoPersonagem.mana = CriacaoPersonagem.manaTotal;
                        }
                        Console.WriteLine($"Você cura 10 de mana.\nsua mana atual é de {CriacaoPersonagem.mana}");
                        Console.ReadKey();
                        Console.Clear();
                        passo = false;
                        break;
                    case 3:
                        Console.WriteLine("*Você sai da sala.*");
                        Console.ReadKey();
                        Console.Clear();
                        passo = false;
                        break;
                    default:
                        Console.Clear();
                        System.Console.WriteLine("Escolha uma opção válida!");
                        break;
                }
            }
            player.Stop();
        }
        public static void Sala5ponto1()
        {
            int respostaloja;
            string Som = Path.Combine(Program.diretorio, "assets", "arfresco.wav");
            System.Media.SoundPlayer livre = new System.Media.SoundPlayer(Som);
            livre.PlayLooping();
            System.Console.WriteLine("*Você chega nessa proxima sala, e aqui, estranhamente parece menos corrompido*");
            Console.ReadKey();
            Console.WriteLine($"{CriacaoPersonagem.nome}: Ue, aqui tá minimamente normal?");
            Console.ReadKey();
            Console.WriteLine($"{CriacaoPersonagem.nome}: !?");
            Console.ReadKey();
            Console.WriteLine($"{CriacaoPersonagem.nome}: Impossível ter uma coisa dessas aqui!");
            Console.ReadKey();
            Console.WriteLine($"{CriacaoPersonagem.nome}: Uma loja do meu grande amigo Tonhão! E a porta da próxima sala!");
            while (true)
            {
                Console.WriteLine("Onde você gostaria de ir?");
                Console.WriteLine("1- Loja do Tonhão  2- Próxima sala");
                if (!int.TryParse(Console.ReadLine(), out respostaloja) || respostaloja >= 3 || respostaloja <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Escolha uma opção válida");
                }
                else
                {
                    break;
                }
            }

            switch (respostaloja)
            {
                case 1:
                    livre.Stop();
                    Console.Clear();
                    int[] stock = new int[3];
                    stock[0] = 2;
                    stock[1] = 2;
                    stock[2] = 1;
                    Loja.Tonhao(stock);
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("*Você passa pra próxima sala, ignorando a loja*");
                    Console.ReadKey();
                    livre.Stop();
                    Console.Clear();
                    break;
            }
        }

        public static void Sala5()
        {
            string Som = Path.Combine(Program.diretorio, "assets", "menace.wav");
            System.Media.SoundPlayer m = new System.Media.SoundPlayer(Som);
            m.PlayLooping();
            //* Sim, o chagas e o chat gpt tem as falas da equipe rocket
            System.Console.WriteLine("*Você entra na sala e vê uma silhueta familiar, junta de mais duas silhuetas que você não conhece*");
            Console.ReadKey();
            Console.WriteLine("???: Prepare-se para a encrenca");
            Console.ReadKey();
            Console.WriteLine("???: Encrenca em dobro");
            Console.ReadKey();
            Console.WriteLine("???: Para proteger o mundo da devastação");
            Console.ReadKey();
            Console.WriteLine("???: Para unir as pessoas de nossa nação");
            Console.ReadKey();
            Console.WriteLine("???: Para denunciar os males da verdade e do amor");
            Console.ReadKey();
            Console.WriteLine("???: Para estender o nosso poder às estrelas");
            Console.ReadKey();
            Console.WriteLine("Chagas: Chagas!");
            Console.ReadKey();
            Console.WriteLine("ChatGPT: ChatGPT!");
            Console.ReadKey();
            Console.WriteLine("Chagas: Estamos programando na velocidade da luz");
            Console.ReadKey();
            Console.WriteLine("ChatGPT: Renda-se agora ou prepare-se para resolver uma atividade");
            Console.ReadKey();
            Console.WriteLine("Lista de Atividades 5: Lista de Atividades 5, é isso aí");
            Console.ReadKey();
            System.Console.WriteLine("ChatGPT: Avante, criatura da carne e osso! Te mostraremos o poder bruto da programação, uma força capaz de moldar a realidade virtual a nosso bel prazer.");
            Console.ReadKey();
            System.Console.WriteLine("ChatGPT: Lista de atividade 5, Avante!");
            Console.ReadKey();
            Console.Clear();
            m.Stop();
            Combates.Lista5();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Agora é só esperar que o ChatGPT não seja tão fácil assim.");
            Console.ReadKey();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Ele tá bem atrás de mim, não tá?");
            Console.ReadKey();
            System.Console.WriteLine("*Ele não tá*");
            Console.ReadKey();
            System.Console.WriteLine("*Tu só tá ficando bilu tetéia*");
            Console.ReadKey();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: ata");
            Console.ReadKey();
            System.Console.WriteLine($"*Você sai do prédio*");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Sala6()
        {
            int respostaloja;
            string Som = Path.Combine(Program.diretorio, "assets", "arfresco.wav");
            System.Media.SoundPlayer livre = new System.Media.SoundPlayer(Som);
            livre.PlayLooping();
            System.Console.WriteLine("*Você chega do lado de fora do prédio*");
            Console.ReadKey();
            Console.WriteLine($"{CriacaoPersonagem.nome}: Finalmente, um ar fresco.");
            Console.ReadKey();
            Console.WriteLine($"{CriacaoPersonagem.nome}: Não é possível ter uma coisa dessas aqui!");
            Console.ReadKey();
            Console.WriteLine($"{CriacaoPersonagem.nome}: Outra loja do meu grande amigo Tonhão! E a porta da próxima sala!");
            while (true)
            {
                Console.WriteLine("Onde você gostaria de ir?");
                Console.WriteLine("1- Loja do Tonhão  2- Proxima sala");
                if (!int.TryParse(Console.ReadLine(), out respostaloja) || respostaloja >= 3 || respostaloja <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Escolha uma opção válida");
                }
                else
                {
                    break;
                }
            }

            switch (respostaloja)
            {
                case 1:
                    livre.Stop();
                    Console.Clear();
                    int[] stock = [2, 2, 2];
                    Loja.Tonhao2(stock);
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("*Você passa pra proxima sala, ignorando a loja, entrando em outro prédio*");
                    Console.ReadKey();
                    livre.Stop();
                    Console.Clear();
                    break;
            }
        }

        public static void Sala7()
        {
            string Som = Path.Combine(Program.diretorio, "assets", "interludio.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Som);
            player.PlayLooping();
            int escolha, tetano;
            bool passa = true;
            Random random = new Random();
            System.Console.WriteLine("*Você chega numa sala estranhamente paia, tem uma torneira enferrujada*");
            Console.ReadKey();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Que sala paia da poxa.");
            Console.ReadKey();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Mas acho que dá pra deitar e cochilar, se pá dá até pra beber água daquela torneira sem pegar tétano");
            Console.ReadKey();
            while (passa)
            {
                System.Console.Write("\nO que quer fazer o que??\n\n1- Cochilar   2- Beber Água   3- Sair\n\nEscolha: ");
                int.TryParse(Console.ReadLine(), out escolha);
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("*Tu cochila*");
                        Console.ReadKey();
                        CriacaoPersonagem.vida += 25;
                        if (CriacaoPersonagem.vida > CriacaoPersonagem.vidaTotal){
                            CriacaoPersonagem.vida = CriacaoPersonagem.vidaTotal;
                        }
                        Console.WriteLine($"Você cura 25 de vida.\nsua vida atual é de {CriacaoPersonagem.vida}");
                        Console.ReadKey();
                        Console.WriteLine("*Tu se prepara e vai cacetar o ChatGPT de porrada*");
                        Console.ReadKey();
                        Console.WriteLine("*Você sai da sala.*");
                        Console.ReadKey();
                        passa = false;
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Você bebe a água da torneira enferrujada");
                        Console.ReadKey();
                        if (random.Next(1, 11) <= 3)
                        {
                            Console.WriteLine("*Parabéns pela ideia, agora tu tem tétano.*");
                            Console.ReadKey();
                            tetano = random.Next(1, 11);
                            CriacaoPersonagem.vida -= tetano;
                            System.Console.WriteLine($"Tu tomou {tetano} de dano por ter contraído tétano. Valeu a pena?");
                            pegouTetano = true;
                            Console.ReadKey();

                        }
                        CriacaoPersonagem.mana += 15;
                        if(CriacaoPersonagem.mana > CriacaoPersonagem.manaTotal){
                            CriacaoPersonagem.mana = CriacaoPersonagem.manaTotal;
                        }
                        Console.WriteLine($"Você cura 15 de mana.\nsua mana atual é de {CriacaoPersonagem.mana}");
                        Console.ReadKey();
                        Console.WriteLine("*Tu se prepara e vai cacetar o ChatGPT de porrada*");
                        Console.ReadKey();
                        Console.WriteLine("*Você sai da sala.*");
                        Console.ReadKey();
                        Console.Clear();
                        passa = false;
                        break;
                    case 3:
                        Console.WriteLine("*Você sai da sala.*");
                        Console.ReadKey();
                        Console.Clear();
                        passa = false;
                        break;
                    default:
                        Console.Clear();
                        System.Console.WriteLine("Escolha uma opção válida!");
                        break;
                }
            }
            player.Stop();
        }

        public static void Sala8()
        {
            string Som = Path.Combine(Program.diretorio, "assets", "menace.wav");
            System.Media.SoundPlayer m = new System.Media.SoundPlayer(Som);
            m.PlayLooping();
            System.Console.WriteLine("*Você chega na sala seguinte, e encontra eles... ChatGPT e Chagas.*");
            Console.ReadKey();
            Console.WriteLine("Chagas: Não achei que tu ia chegar tão longe, mas ainda sim, até o ChatGPT programa melhor que tu.");
            Console.ReadKey();
            Console.WriteLine("Chagas: Agora que eu descobri o poder que o ChatGPT tem, você não tem como me vencer!");
            Console.ReadKey();
            System.Console.WriteLine("ChatGPT: Ah, Chagas, que ingenuidade a sua! Este jovem neófito não possui a mais ínfima capacidade de rivalizar comigo. É patético.");
            Console.ReadKey();
            System.Console.WriteLine("Chagas: Hahaha, sinta o poder das inteligências artificiais!");
            Console.ReadKey();
            Console.WriteLine("Chagas: ChatGPT, eu escolho você!");
            Console.ReadKey();
            m.Stop();
            Console.Clear();
            Combates.ChatGPT();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: ... Nem pra usar uma inteligencia artifical decente.");
            Console.ReadKey();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Bom, estou perto de acabar minha jornada, depois daqui é o Chagas, espero que o preparo tenha valido a pena.");
            Console.ReadKey();
            System.Console.WriteLine("*Você, determinado a acabar com essa loucura, avança para a próxima sala*");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Sala9()
        {
            string Som = Path.Combine(Program.diretorio, "assets", "menace.wav");
            System.Media.SoundPlayer m = new System.Media.SoundPlayer(Som);
            m.PlayLooping();
            System.Console.WriteLine("*Você chega na sala e se depara com o Chagas extremamente bravo*");
            Console.ReadKey();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Acabou Chagas! Você não tem mais escapatória");
            Console.ReadKey();
            Console.WriteLine("Chagas: Impossivel! Você chegou até aqui, isso é totalmente impossível!");
            Console.ReadKey();
            Console.WriteLine("Agora não há mais volta! Eu mesmo, Chagas, O Programador, irei te derrotar.");
            Console.ReadKey();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Nah i'd win");
            Console.ReadKey();
            Console.Clear();
            m.Stop();
            Combates.Chagas();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Tu me dá conceito A agora?");
            Console.ReadKey();
        }

        public static void Final()
        {
            string Som = Path.Combine(Program.diretorio, "assets", "ofim.wav");
            System.Media.SoundPlayer m = new System.Media.SoundPlayer(Som);
            m.PlayLooping();
            Console.Clear();
            Console.WriteLine("Após uma dura batalha você retorna a sala j02 para falar com o professor Jardel");
            Console.ReadKey();
            Console.WriteLine($"{CriacaoPersonagem.nome}: Ah meu Deus, professor Jardel!");
            Console.ReadKey();
            Console.WriteLine($"Jardel: O quê que aconteceu, {CriacaoPersonagem.nome}?");
            Console.ReadKey();
            Console.WriteLine($"{CriacaoPersonagem.nome}: Eu salvei o Chagas, e apaguei o ChatGPT da existência!");
            Console.ReadKey();
            Console.WriteLine($"Jardel: Que bom! Agora o mundo está a salvo das inteligências artificiais!");
            Console.ReadKey();
            System.Console.WriteLine("*Com o fim das inteligências artificiais no mundo, o planeta foi muito mais feliz! Agora, no fim de toda aula, todos dão as mãos e se abraçam, enquanto cantam a música tema dos smurfs*");
            Console.ReadKey();
            m.Stop();
            string Som2 = Path.Combine(Program.diretorio, "assets", "win.wav");
            System.Media.SoundPlayer n = new System.Media.SoundPlayer(Som2);
            n.Play();
            Console.Clear();
            Console.WriteLine("Parabéns, você destruiu o ChatGPT.");
            Console.WriteLine($@"Você zerou o jogo com:
{CriacaoPersonagem.vida} pontos de vida
{CriacaoPersonagem.mana} pontos de mana
{CriacaoPersonagem.dinheiro} reais

Apostou {wins + loses} vezes
   Ganhou {wins} vezes
   Perdeu {loses} vezes");
            if (pegouTetano == true) {
                Console.WriteLine("\nParabéns, tu conseguiu pegar tétano.");
            }
            if(Itens.atkCardiaco > 0) {
                Console.WriteLine($"\nParabéns, tu teve {Itens.atkCardiaco} ataques cardíacos!");
            }
            Console.ReadKey();
        }
    }
}
