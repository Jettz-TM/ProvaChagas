using System;
namespace Jogo
{
    class MenuInicio
    {
        public static void Menu()
        {
            int escolha;
            bool passa = true;
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
                            Console.WriteLine("Itens: Wagner");
                            Console.WriteLine("Roteiro: Todos");
                            Console.WriteLine("\nNiord como: Chagas");
                            Console.WriteLine("Jardel como: Jardel");
                            Console.WriteLine("Gemini como: Chat GPT");
                            Console.WriteLine("Renê como: Reninho");
                            Console.WriteLine("Menção Honrosa: Oto Sefarim Ribeiro \n Ele nos ajudou com metodos mais praticos para programar o jogo \n Valeu Oto <3");
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