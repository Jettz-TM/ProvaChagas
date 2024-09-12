using System;
namespace Jogo
{
    class Salas
    {
        public static void Introdução()
        {
            //Console.WriteLine("");
            Console.WriteLine("Fortaleza, CE\n");
            Console.WriteLine("Segunda feira, as 3:33 da manhã você recebe uma mensagem do professor Jardel");
            Console.WriteLine($"Jardel:{Program.nome} preciso de sua ajuda! O professor Chagas enloqueceu!");
            Console.WriteLine("Chagas transformou os alunos em algum tipo de coisa mostruosa através do Chat GPT.");
            Console.WriteLine("Preciso de sua ajuda imediatamente, venha rapido até o senai, estou na sala J2");
            Console.ReadKey();
        }
        public static void Sala1()
        {
            Console.WriteLine("Jardel:Finalmente voce chegou!");
            Console.WriteLine("Jardel:Agora nos resta enfrentar o Chagas e os alunos");
            Console.WriteLine($"{Program.nome} pegue este soco inglês e enfrente quem estiver no caminho");
            Console.WriteLine("Lembre-se que pode haver lojinhas espalhadas pelo colegio");
        }
        public static void Sala2()
        {
            Console.WriteLine("Aluno transformado: V0c3 s0 p455ará s3 m3us c0dig05 corromperem!");
            //Colocar o sistema de batalha 1 + passar de fase
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