using System;
using System.Media;
using System.Runtime.ConstrainedExecution;
namespace Jogo
{
    class Loja
    {
        public static int deixa = 0;
        public static void Tonhao(int[] stock)
        {
            string Som = Path.Combine(Program.diretorio, "assets", "tonhao.wav");
            System.Media.SoundPlayer tonhao = new System.Media.SoundPlayer(Som);
            tonhao.PlayLooping();
            int preco, escolha1, escolha2;
            bool teste = false;
            while (teste == false)
            {
                while (true)
                {
                    Console.Clear();
                    System.Console.WriteLine("Bem-vindo a loja do Tonhão: onde meu lucro é a sua decepção! \nEscolha uma ação:\n1 - comprar\n2 - sair");
                    if (!int.TryParse(System.Console.ReadLine(), out escolha1) || escolha1 < 1 || escolha1 > 2)
                    {
                        Console.Clear();
                        System.Console.WriteLine("Digite um valor valido");
                    }
                    else
                    {
                        break;
                    }
                }
                if (escolha1 == 1)
                {
                    Console.Clear();
                    teste = true;
                    while (teste == true)
                    {
                        string item = "a";
                        while (true)
                        {
                            System.Console.WriteLine("Tonhão: O que desejas?");
                            System.Console.WriteLine($"Dinheiro: {CriacaoPersonagem.dinheiro}\n0 - Sair\n1 - Salgado: 5$\n2 - Energético: 5$\n3 - Camisa do interclasse: 15$");
                            if (!int.TryParse(System.Console.ReadLine(), out escolha2) || escolha2 < 0 || escolha2 > 3)
                            {
                                Console.Clear();
                                System.Console.WriteLine("Digite um valor valido!");
                            }
                            else
                            {
                                break;
                            }
                        }
                        Inventario.CheckInv(Program.matrizinv);

                        if (escolha2 == 1)
                        {
                            if (Loja.deixa < 9)
                            {
                                if (stock[0] > 0)
                                {
                                    preco = 5;
                                    if (CriacaoPersonagem.dinheiro < 5)
                                    {
                                        Console.Clear();
                                        System.Console.WriteLine("DINHEIRO INSUFICIENTE!!!");
                                        Console.ReadKey();
                                        System.Console.WriteLine("Tonhão: Seu pobre imundo.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        System.Console.WriteLine("Tonhão: Que isso prolongue sua eventual morte. <3");
                                        CriacaoPersonagem.dinheiro = CriacaoPersonagem.dinheiro - preco;
                                        stock[0] = stock[0] - 1;
                                        item = "Salgado";
                                        Inventario.ChangeInv(Program.matrizinv, item);
                                        Inventario.ShowInv(Program.matrizinv);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    System.Console.WriteLine("Tonhão: Desculpe, o estoque acabou.");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                System.Console.WriteLine("Tonhão: Você não aguenta levar mais itens");
                            }
                        }
                        else if (escolha2 == 2)
                        {
                            if (Loja.deixa < 9)
                            {
                                if (stock[1] > 0)
                                {
                                    preco = 5;
                                    if (CriacaoPersonagem.dinheiro < 5)
                                    {
                                        Console.Clear();
                                        System.Console.WriteLine("DINHEIRO INSUFICIENTE!!!");
                                        Console.ReadKey();
                                        System.Console.WriteLine("Tonhão: Seu pobre imundo.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        
                                        System.Console.WriteLine("Que seja útil na sua jornada.");
                                        stock[1] = stock[1] - 1;
                                        CriacaoPersonagem.dinheiro = CriacaoPersonagem.dinheiro - preco;
                                        item = "Energetico";
                                        Inventario.ChangeInv(Program.matrizinv, item);
                                        Inventario.ShowInv(Program.matrizinv);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    System.Console.WriteLine("Tonhão: Desculpe, o estoque acabou.");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                System.Console.WriteLine("Tonhão: Você não aguenta levar mais itens");
                            }

                        }
                        else if (escolha2 == 3)
                        {
                            if (Loja.deixa < 9)
                            {
                                preco = 15;
                                if (stock[2] > 0)
                                {
                                    if (CriacaoPersonagem.dinheiro < 15)
                                    {
                                        Console.Clear();
                                        System.Console.WriteLine("DINHEIRO INSUFICIENTE!!!");
                                        Console.ReadKey();
                                        System.Console.WriteLine("Tonhão: Seu pobre imundo.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        System.Console.WriteLine("Não há muitos desses itens por aqui, tome cuidado com isso");
                                        CriacaoPersonagem.dinheiro = CriacaoPersonagem.dinheiro - preco;
                                        stock[2] = stock[2] - 1;
                                        CriacaoPersonagem.buffArmadura = 8;
                                        item = "Uniforme do Interclasse";
                                        Inventario.ChangeInv(Program.matrizinv, item);
                                        Inventario.ShowInv(Program.matrizinv);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    System.Console.WriteLine("Tonhão: Desculpe, o estoque acabou.");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                System.Console.WriteLine("Tonhão: Você não aguenta levar mais itens");
                            }
                        }

                        else if (escolha2 == 0)
                        {
                            teste = false;
                        }
                    }
                }
                else if (escolha1 == 2)
                {
                    System.Console.WriteLine("Ja vai embora?");
                    break;
                }
            }
            System.Console.WriteLine("Volte mais tarde! (com mais grana e claro se não nem volta)");
            Console.ReadKey();
            tonhao.Stop();
        }
        public static void Tonhao2(int[] stock)
        {
            string Som = Path.Combine(Program.diretorio, "assets", "tonhao.wav");
            System.Media.SoundPlayer tonhao = new System.Media.SoundPlayer(Som);
            tonhao.PlayLooping();
            int preco, escolha1, escolha2;
            bool teste = false;
            while (teste == false)
            {
                while (true)
                {
                    Console.Clear();
                    System.Console.WriteLine("Bem-vindo a loja do Tonhão: onde meu lucro é a sua decepção! \nEscolha uma ação:\n1 - comprar\n2 - sair");
                    if (!int.TryParse(System.Console.ReadLine(), out escolha1) || escolha1 < 1 || escolha1 > 2)
                    {
                        Console.Clear();
                        System.Console.WriteLine("Digite um valor valido");
                    }
                    else
                    {
                        break;
                    }
                }
                if (escolha1 == 1)
                {
                    Console.Clear();
                    teste = true;
                    while (teste == true)
                    {
                        string item = "a";
                        while (true)
                        {
                            System.Console.WriteLine("Tonhão: O que desejas?");
                            System.Console.WriteLine($"Dinheiro: {CriacaoPersonagem.dinheiro}\n0 - Sair\n1 - Salgado: 5$\n2 - Energético: 5$\n3 - Sorvete de Chocolate: 15$");
                            if (!int.TryParse(System.Console.ReadLine(), out escolha2) || escolha2 < 0 || escolha2 > 3)
                            {
                                Console.Clear();
                                System.Console.WriteLine("Digite um valor valido!");
                            }
                            else
                            {
                                break;
                            }
                        }
                        Inventario.CheckInv(Program.matrizinv);

                        if (escolha2 == 1)
                        {
                            if (Loja.deixa < 9)
                            {
                                if (stock[0] > 0)
                                {
                                    preco = 5;
                                    if (CriacaoPersonagem.dinheiro < 5)
                                    {
                                        Console.Clear();
                                        System.Console.WriteLine("DINHEIRO INSUFICIENTE!!!");
                                        Console.ReadKey();
                                        System.Console.WriteLine("Tonhão: Seu pobre imundo.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        System.Console.WriteLine("Tonhão: Que isso prolongue sua eventual morte. <3");
                                        CriacaoPersonagem.dinheiro = CriacaoPersonagem.dinheiro - preco;
                                        stock[0] = stock[0] - 1;
                                        item = "Salgado";
                                        Inventario.ChangeInv(Program.matrizinv, item);
                                        Inventario.ShowInv(Program.matrizinv);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    System.Console.WriteLine("Tonhão: Desculpe, o estoque acabou.");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                System.Console.WriteLine("Tonhão: Você não aguenta levar mais itens");
                            }
                        }
                        else if (escolha2 == 2)
                        {
                            if (Loja.deixa < 9)
                            {
                                if (stock[1] > 0)
                                {
                                    preco = 5;
                                    if (CriacaoPersonagem.dinheiro < 5)
                                    {
                                        Console.Clear();
                                        System.Console.WriteLine("DINHEIRO INSUFICIENTE!!!");
                                        Console.ReadKey();
                                        System.Console.WriteLine("Tonhão: Seu pobre imundo.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        
                                        System.Console.WriteLine("Que seja útil na sua jornada.");
                                        stock[1] = stock[1] - 1;
                                        CriacaoPersonagem.dinheiro = CriacaoPersonagem.dinheiro - preco;
                                        item = "Energetico";
                                        Inventario.ChangeInv(Program.matrizinv, item);
                                        Inventario.ShowInv(Program.matrizinv);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    System.Console.WriteLine("Tonhão: Desculpe, o estoque acabou.");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                System.Console.WriteLine("Tonhão: Você não aguenta levar mais itens");
                            }

                        }
                        else if (escolha2 == 3)
                        {
                            if (Loja.deixa < 9)
                            {
                                preco = 15;
                                if (stock[2] > 0)
                                {
                                    if (CriacaoPersonagem.dinheiro < 15)
                                    {
                                        Console.Clear();
                                        System.Console.WriteLine("DINHEIRO INSUFICIENTE!!!");
                                        Console.ReadKey();
                                        System.Console.WriteLine("Tonhão: Seu pobre imundo.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        System.Console.WriteLine("Não há muitos desses itens por aqui, tome cuidado com isso");
                                        CriacaoPersonagem.dinheiro = CriacaoPersonagem.dinheiro - preco;
                                        stock[2] = stock[2] - 1;
                                        item = "Sorvete de Chocolate";
                                        Inventario.ChangeInv(Program.matrizinv, item);
                                        Inventario.ShowInv(Program.matrizinv);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    System.Console.WriteLine("Tonhão: Desculpe, o estoque acabou.");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                System.Console.WriteLine("Tonhão: Você não aguenta levar mais itens");
                            }
                        }

                        else if (escolha2 == 0)
                        {
                            teste = false;
                        }
                    }
                }
                else if (escolha1 == 2)
                {
                    System.Console.WriteLine("Ja vai embora?");
                    break;
                }
            }
            System.Console.WriteLine("Volte mais tarde! (com mais grana e claro se não nem volta)");
            Console.ReadKey();
            tonhao.Stop();
        }
    }
}