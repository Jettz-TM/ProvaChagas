using System;
namespace Jogo
{
    class PerguntasGPT
    {
        public static void Pergunta1()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que falta no código?\n\nConsole.WriteLine('Olá Mundo!!')\n");
                {
                    switch (Combates.resposta)
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
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }

        public static void Pergunta2()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("Como corrigir o código?\n\nif (i >= 5 or i <= 10) {}\n");
                {
                    switch (Combates.resposta)
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
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }

        public static void Pergunta3()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que falta no código?\n\nfor (int i; i <= 10; i++) {}\n");
                {
                    switch (Combates.resposta)
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
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }

        public static void Pergunta4()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que falta no código?\n\nstring nome = Bruno;\n");
                {
                    switch (Combates.resposta)
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
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }

        public static void Pergunta5()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que está de errado com o código?\n\nConsole.ReadLine(nome);\n");
                {
                    switch (Combates.resposta)
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
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }

        public static void Pergunta6()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que está de errado com o código?\n\nint nome;\nnome = Console.ReadLine();\n");
                {
                    switch (Combates.resposta)
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
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }

        public static void Pergunta7()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que falta com o código?\n\nConsole.WriteLine('O nome digitado é: {nome}');");
                {
                    switch (Combates.resposta)
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
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }

        public static void Pergunta8()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que tem de errado no código?\nconst int numero = 1; \nnumero = 2;");
                {
                    switch (Combates.resposta)
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
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }

        }
        public static void Pergunta9()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("Qual é o erro no código abaixo?\n\nint[] numeros = [4]};\n");
                {
                    switch (Combates.resposta)
                    {
                        case 1:
                            Console.Write("1- Falta o 'new int[]' \n2- Não pode usar arrays com números \n3- Falta um ;\n\nEscolha: ");
                            break;
                        case 2:
                            Console.Write("1- Não pode usar arrays com números \n2- Falta o 'new int[]' \n3- Falta um ;\n\nEscolha: ");
                            break;
                        case 3:
                            Console.Write("1- Falta um ; \n2- Não pode usar arrays com números \n3- Falta o 'new int[]'\n\nEscolha: ");
                            break;
                    }
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }

        public static void Pergunta10()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("Qual é o problema com o loop?\n\nfor (int i = 0; i <= 10; ) {}\n");
                {
                    switch (Combates.resposta)
                    {
                        case 1:
                            Console.Write("1- Falta 'i++' \n2- O loop é infinito \n3- Falta um ;\n\nEscolha: ");
                            break;
                        case 2:
                            Console.Write("1- O loop é infinito \n2- Falta 'i++' \n3- Falta um ;\n\nEscolha: ");
                            break;
                        case 3:
                            Console.Write("1- Falta um ; \n2- O loop é infinito \n3- Falta 'i++'\n\nEscolha: ");
                            break;
                    }
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }
        public static void Pergunta11()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que está faltando neste código?\n\nif (idade = 18) {}\n");
                {
                    switch (Combates.resposta)
                    {
                        case 1:
                            Console.Write("1- Falta '==' para comparação \n2- Falta um ; \n3- Falta {}\n\nEscolha: ");
                            break;
                        case 2:
                            Console.Write("1- Falta {} \n2- Falta '==' para comparação \n3- Falta um ;\n\nEscolha: ");
                            break;
                        case 3:
                            Console.Write("1- Falta um ; \n2- Falta {} \n3- Falta '==' para comparação\n\nEscolha: ");
                            break;
                    }
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }

        public static void Pergunta12()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("Qual o erro no array abaixo?\n\nint[] numeros = new int[5];\nnumeros[5] = 10;\n");
                {
                    switch (Combates.resposta)
                    {
                        case 1:
                            Console.Write("1- Índice fora do intervalo \n2- Não pode inicializar o array assim \n3- Falta um ;\n\nEscolha: ");
                            break;
                        case 2:
                            Console.Write("1- Não pode inicializar o array assim \n2- Índice fora do intervalo \n3- Falta um ;\n\nEscolha: ");
                            break;
                        case 3:
                            Console.Write("1- Falta um ; \n2- Não pode inicializar o array assim \n3- Índice fora do intervalo\n\nEscolha: ");
                            break;
                    }
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }

        public static void Pergunta13()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que está errado neste loop?\n\nwhile (i > 0) {}\n");
                {
                    switch (Combates.resposta)
                    {
                        case 1:
                            Console.Write("1- Falta inicializar 'i' \n2- O loop é infinito \n3- Falta um ;\n\nEscolha: ");
                            break;
                        case 2:
                            Console.Write("1- O loop é infinito \n2- Falta inicializar 'i' \n3- Falta um ;\n\nEscolha: ");
                            break;
                        case 3:
                            Console.Write("1- Falta um ; \n2- O loop é infinito \n3- Falta inicializar 'i'\n\nEscolha: ");
                            break;
                    }
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }

        public static void Pergunta14()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que está de errado com o código abaixo?\n\nint[] numeros = new int[] {1, 2, 3};\nfor (int i = 0; i <= numeros.Length; i++) {}\n");
                {
                    switch (Combates.resposta)
                    {
                        case 1:
                            Console.Write("1- O índice vai além do tamanho do array \n2- Falta 'i++' \n3- Falta um ;\n\nEscolha: ");
                            break;
                        case 2:
                            Console.Write("1- Falta 'i++' \n2- O índice vai além do tamanho do array \n3- Falta um ;\n\nEscolha: ");
                            break;
                        case 3:
                            Console.Write("1- Falta um ; \n2- Falta 'i++' \n3- O índice vai além do tamanho do array\n\nEscolha: ");
                            break;
                    }
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }
        public static void Pergunta15()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que está errado no método abaixo?\n\npublic void MeuMetodo() { Console.WriteLine('Olá Mundo'); }\n");
                {
                    switch (Combates.resposta)
                    {
                        case 1:
                            Console.Write("1- Falta o Static \n2- Aspas simples ao invés de aspas duplas \n3- Falta um ';' \n\nEscolha: ");
                            break;
                        case 2:
                            Console.Write("1- Falta um ';' \n2- Falta o Static \n3- Aspas simples ao invés de aspas duplas \n\nEscolha: ");
                            break;
                        case 3:
                            Console.Write("1- Aspas simples ao invés de aspas duplas \n2- Falta um ';' \n3- Falta o Static \n\nEscolha: ");
                            break;
                    }
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }
        public static void Pergunta16()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine($"Vida: {CriacaoPersonagem.vida}\nVida do ChatGPT: {Combates.vidaGPT}");
                Console.WriteLine("O que está de errado no código abaixo?\n\nList<int> numeros = new List<int>();\nnumeros.Add(1);\nnumeros.RemoveAt(1);\n");
                {
                    switch (Combates.resposta)
                    {
                        case 1:
                            Console.Write("1- O índice do RemoveAt é inválido \n2- Falta inicializar o List \n3- Não pode usar RemoveAt com List \n\nEscolha: ");
                            break;
                        case 2:
                            Console.Write("1- Falta inicializar o List \n2- O índice do RemoveAt é inválido \n3- Não pode usar RemoveAt com List \n\nEscolha: ");
                            break;
                        case 3:
                            Console.Write("1- Não pode usar RemoveAt com List \n2- Falta inicializar o List \n3- O índice do RemoveAt é inválido \n\nEscolha: ");
                            break;
                    }
                }
                if (!int.TryParse(Console.ReadLine(), out Combates.escolha) || Combates.escolha < 1 || Combates.escolha > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma resposta válida\n");
                }
                else if (Combates.escolha == Combates.resposta)
                {
                    Combates.dano = random.Next(1, 16);
                    Console.Write($"Você corrigiu o código e deu {Combates.dano + CriacaoPersonagem.forca} de dano!");
                    Console.ReadLine();
                    Combates.vidaGPT -= Combates.dano + CriacaoPersonagem.forca;
                    break;
                }
                else
                {
                    Combates.dano = random.Next(1, 11);
                    Console.Write($"Tu não corrigiu o código e o Chagas deu esporro, tu tomou {Combates.dano} de dano");
                    Console.ReadLine();
                    CriacaoPersonagem.vida -= Combates.dano;
                    break;
                }
            }
        }
        

    }
}
