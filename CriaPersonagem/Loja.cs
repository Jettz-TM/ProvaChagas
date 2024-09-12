using System;
using System.Media;
namespace Jogo
{
    class Loja
    {
        public static void Tonhao()
        {
            int moedas = 50, preco;
            char escolha1, escolha2;
            bool teste = false;

            while (teste == false)
            {
                System.Console.WriteLine("Bem-vindo a loja do Tonhão: onde meu lucro é a sua decepção! \nEscolha uma ação:\n1 - comprar\n2 - sair");

                char.TryParse(System.Console.ReadLine(), out escolha1);
                if (escolha1 == '1')
                {
                    teste = true;
                    while (teste == true)
                    {
                        System.Console.WriteLine($"Moedas de ouro: {moedas}\n0 - Sair\n1 - Poção de cura: 5$\n2 - Arnadura de couro: 10$\n3 - Espada de ferro: 15$");

                        char.TryParse(System.Console.ReadLine(), out escolha2);

                        if (escolha2 == '1')
                        {
                            preco = 5;
                            if (moedas < 5)
                            {
                                System.Console.WriteLine("MOEDAS INSUFICIENTE!!!");
                                Console.ReadLine();
                            }
                            else
                            {
                                moedas = moedas - preco;
                            }
                        }
                        else if (escolha2 == '2')
                        {
                            preco = 10;
                            if (moedas < 10)
                            {
                                System.Console.WriteLine("MOEDAS INSUFICIENTE!!!");
                                Console.ReadLine();
                            }
                            else
                            {
                                moedas = moedas - preco;
                            }
                        }
                        else if (escolha2 == '3')
                        {
                            preco = 15;
                            if (moedas < 15)
                            {
                                System.Console.WriteLine("MOEDAS INSUFICIENTE!!!");
                                Console.ReadLine();
                            }
                            else
                            {
                                moedas = moedas - preco;
                            }
                        }
                        else if (escolha2 == '0')
                        {
                            teste = false;
                        }
                    }
                }
                else if (escolha1 == '2')
                {
                    break;
                }
            }
            System.Console.WriteLine("Volte mais tarde! (com mais grana por favor)");
        }
    }
}