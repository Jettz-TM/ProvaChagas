using System;
using System.Media;
namespace Jogo
{
    class Salas
    {
        public static void Introdução()
        {
            Console.WriteLine("Fortaleza, CE\n");
            Console.ReadKey();
            Console.WriteLine("Segunda feira, as 3:33 da manhã você recebe uma mensagem do professor Jardel");
            Console.ReadKey();
            Console.WriteLine($"Jardel:{Program.nome} preciso de sua ajuda! O professor Chagas enloqueceu!");
            Console.ReadKey();
            Console.WriteLine("Chagas transformou os alunos em algum tipo de coisa mostruosa através do Chat GPT.");
            Console.ReadKey();
            Console.WriteLine("Preciso de sua ajuda imediatamente, venha rapido até o senai, estou na sala J2");
            Console.ReadKey();
            System.Console.WriteLine("*Você se prepara e sai para ajudar o Jardel com essa situação*");
            Console.ReadKey();
            Console.Clear();
            
        }
        public static void Sala1()
        {
            string item = "Soco Inglês";
            CriacaoPersonagem.buffArma = 5;
            Console.WriteLine("*Você chega no Senai, e uma situação critica, tudo parece corrompido e estranho*");
            Console.ReadKey();
            Console.WriteLine("*Nada parece fazer sentido, mas sem raciocinar muito, voce chega na sala do jardel*");
            Console.ReadKey();
            Console.WriteLine("Jardel: Finalmente voce chegou!");
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
            Console.WriteLine("\nJardel: Lembre-se que pode haver lojinhas espalhadas pelo colegio");
            Console.ReadKey();
            System.Console.WriteLine("*Você sai da sala do Jardel*");
            Console.ReadKey();
        }
        public static void Sala2()
        {
            string Som = Path.Combine(Program.diretorio, "assets", "infectados.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Som);
            player.PlayLooping();
            Console.Clear();
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
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Isso foi muito estranho... Enfim, tem uma saida aqui, é melhor eu seguir por este caminho.");
            System.Console.WriteLine("**");
            Console.Clear();
        }
        public static void Sala3()
        {
            //TODO: Colocar a  opção de sair
            int respostaloja;

            Console.WriteLine($"{Program.nome}:Finalmente, um ar fresco.");
            Console.WriteLine($"{Program.nome}:Impossivel ter uma coisa dessas aqui!");
            Console.WriteLine($"{Program.nome}:Uma loja do meu grande amigo Tonhão! E a porta da proxima sala");
            while (true)
            {
                Console.WriteLine("Onde você gostaria de ir?");
                Console.WriteLine("1- Loja do tonhão  2- Proxima sala");
                if (!int.TryParse(Console.ReadLine(), out respostaloja) || respostaloja >= 3 || respostaloja <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Escolha uma opção valida");
                }
                else
                {
                    break;
                }
            }

            switch (respostaloja)
            {
                case 1:
                    Loja.Tonhao();
                    break;
                case 2:
                    Console.WriteLine("*Você passa pra proxima sala, ignorando a loja*");
                    Console.ReadKey();
                    break;
            }




        }
        public static void Sala4()
        {
            int escolha;
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Ah meu Deus, uma sala convenientemente vazia!");
            Console.ReadKey();
            System.Console.WriteLine($"{CriacaoPersonagem.nome}: Acho que eu consigo usar ela para descansar, ou usar itens.");
            Console.ReadKey();
            System.Console.Write("\nO que quer fazer o que??\n\n1- Descansar   2- Usar poção   3- Sair\n\nEscolha: ");
            int.TryParse(Console.ReadLine(), out escolha);
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Você deita e dorme, mesmo o Chat GPT corrompendo tudo na tua volta");
                    Console.ReadKey();
                    Console.WriteLine("Você cura 15 de vida.");
                    Console.ReadKey();
                    CriacaoPersonagem.vida += 15;
                    Console.WriteLine("Tu se prepara e vai desGPTzar o Chat GPT");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Você bebe água pra queimar os circuitos do Chat GPT");
                    Console.ReadKey();
                    Console.WriteLine("Você cura XX de vida"); // TODO: adicionar os itens
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Você sai da sala.");
                    Console.ReadKey();
                    break;
            }
        }
        public static void Sala5()
        {
            //* Sim, o chagas e o chat gpt tem as falas da equipe rocket
            System.Console.WriteLine("*Você entra na sala, e você vê uma silhueta familiar, junta de mais duas silhuetas que você não conhece*");
            Console.ReadKey();
            Console.WriteLine("???: Preparem-se para a encrenca");
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
            Console.WriteLine("Chat GPT: Chat GPT!");
            Console.ReadKey();
            Console.WriteLine("Chagas: Estamos programando na velocidade da luz");
            Console.ReadKey();
            Console.WriteLine("Chat GPT: Renda-se agora ou preparem-se para resolver uma atividade");
            Console.ReadKey();
            Console.WriteLine("Lista de Atividades 5: Lista de Atividades 5, é isso aí");
            Console.ReadKey();
            Combates.Lista5();
        }

        public static void Sala6()
        {
            //luta contra a ia independente
        }

        public static void Sala7()
        {   //TODO: adicionar loja + codigo
            Console.WriteLine("Novamente, meu grande amigo Tonhão!");
        }

        public static void Sala8()
        {
            Console.WriteLine("Chagas: Não achei que tu ia chegar tão longe, mas ainda sim, até o Chat GPT programa melhor que tu.");
            Console.WriteLine("Chagas: Agora que eu descobri o poder que o Chat GPT tem, você não tem como me vencer!");
            Console.WriteLine("Chagas: Sinta o poder do Chat GPT");
            Combates.ChatGPT();
        }
        public static void Sala9()
        {
            Console.WriteLine("Chagas:Impossivel! Você chegou até aqui,isto é totalmente impossível!");
            Console.WriteLine("Agora não há mais volta! Eu mesmo, Chagas, O Programador, irei te derrotar.");
            //começa a batalha
        }
    }
}