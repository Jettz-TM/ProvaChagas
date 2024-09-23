using System;
namespace Jogo
{
    class MenuInicio
    {
        public static void Menu()
        {
            int escolha;
            bool passa = true;
            string Som = Path.Combine(Program.diretorio, "assets", "start.wav");
            System.Media.SoundPlayer m = new System.Media.SoundPlayer(Som);
            m.Play();
            while (passa)
            {
                Console.Clear();
                Console.WriteLine(@" ____  _____ _   _    _    ___   _____ _          
/ ___|| ____| \ | |  / \  |_ _| |_   _| |__   ___ 
\___ \|  _| |  \| | / _ \  | |    | | | '_ \ / _ \
 ___) | |___| |\  |/ ___ \ | |    | | | | | |  __/
|____/|_____|_| \_/_/   \_\___|   |_| |_| |_|\___|
 / ___| __ _ _ __ ___   ___                       
| |  _ / _` | '_ ` _ \ / _ \                      
| |_| | (_| | | | | | |  __/                      
 \____|\__,_|_| |_| |_|\___|                      ");

                Console.WriteLine("\n\n1- Iniciar");
                Console.WriteLine("2- Créditos");
                Console.WriteLine("3- Sair");
                Console.Write("\nEscolha: ");

                if (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma opção válida");
                    Console.ReadKey();
                }
                else
                {
                    switch (escolha)
                    {
                        case 1:
                            passa = false;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Menu: Gustavo");
                            Console.WriteLine("Criação de Personagens: Gustavo");
                            Console.WriteLine("Salas: Maurício e Wagner");
                            Console.WriteLine("Inventário: Maurício e Wagner");
                            Console.WriteLine("Combates: Gustavo e Roney");
                            Console.WriteLine("Loja: Roney");
                            Console.WriteLine("Itens: Wagner");
                            Console.WriteLine("Roteiro: Todos");
                            Console.WriteLine("Renê como: Reninho BetaTester");
                            Console.WriteLine("Menção Honrosa: Oto Ribeiro Serafim \nEle nos ajudou com metodos mais práticos para programar o jogo \nValeu Oto <3");
                            Console.WriteLine("\n\nAperte qualquer coisa para sair.");
                            Console.ReadKey();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}
