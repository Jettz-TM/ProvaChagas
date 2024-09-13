using System;
using System.Media;
namespace Jogo
{
    class Salas
    {
        public static void Introdução()
        {
            //Console.WriteLine("");
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
            player.Stop();
            Console.Clear();
        }
        public static void Sala3()
        {
            //TODO: Colocar a  opção de sair
            int respostaloja;

            Console.WriteLine($"{Program.nome}:Finalmente,um ar fresco");
            Console.WriteLine($"{Program.nome}:Impossivel ter uma coisa dessas aqui!");
            Console.WriteLine($"{Program.nome}:Uma loja do meu gradne amigo Tonhão! E um carro mal estacionado?");
            Console.WriteLine("Onde você gostaria de ir? (digite 1 ou 2)");
            Console.WriteLine("1- Loja do tonhão  2- Carro");
            int.TryParse(Console.ReadLine(), out respostaloja);

            switch (respostaloja)
            {
                case 1:
                    Loja.Tonhao();
                    break;
                case 2:
                    Console.WriteLine("Um carro com placa 4OO2");
                    Console.ReadKey();
                    Sala3();
                    break;
            }




        }
        public static void Sala4()
        {
            Console.WriteLine("???:Finalmente você chegou");
            Console.WriteLine("???:Eu sou o Chagas, o maior programador de todos os tempos! Ajoelhe-se perante a mim!");
            Console.WriteLine("Chagas:Agora que eu descobri o poder que o Chat GPT tem, você não tem como me vencer!");
            Console.WriteLine("Chagas:Sinta o poder do Chat GPT");
            Console.ReadKey();
            //to tipo o chico buarque quando n deixaram eu coolocar pro chagas dizer "puta, biscate" e "gigolo"
        }
        public static void Sala5()
        {
            //colocar o sistema de batalha contra o chat gpt
        }

        public static void Sala6()
        {
            //luta contra a ia independente
        }

        public static void Sala7()
        {   //TODO: adicionar loja + codigo
            Console.WriteLine("Novamente meu grande amigo Tonhão!");
        }

        public static void Sala8()
        {
            Console.WriteLine("Chagas: Não achei que tu ia chegar tão longe, mas ainda sim, até o Chat GPt faz código melhor que tu.");
            Console.WriteLine("Chagas: Divino 'programador' imortal das 8 linguas de codigo dotnet summon GPT");
            Console.WriteLine("Chat GPT: Minhas habilidades de programação superam as suas.");
        }
        public static void Sala9()
        {
            Console.WriteLine("Chagas:Impossivel! Você chegou até aqui,isto é totalmente impossivel");
            Console.WriteLine("Agora não há mais volta! Eu mesmo, Chagas the programmer, irei te derrotar.");
            //começa a batalha
        }
    }
}