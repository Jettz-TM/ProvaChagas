using System;
class Program {
    public static int vida = 50, mana = 25, forca = 0, resist = 0, intel = 0;
    static string? nome;
    static void Main(string[] args) {
       CriacaoPersonagem(); //*leva pra criação de personagem (nome, classe e atributos)
       Combate2(); //*combate contra o chatpgt, no final do jogo
    }

    static void CriacaoPersonagem() {
         int escolha = 0, pontos = 3;

        Console.Write("Digite o nome do seu personagem: ");
        nome = Console.ReadLine();

        do {
            Console.Clear();
            
            Console.Write("Qual a sua classe?\n\n1- Membro da Robótica  2- Campeão do Interclasse  3- Gênio do Clash\n\nEscolha: ");
            int.TryParse(Console.ReadLine(), out escolha);
            //* cada classe dá 3 pontos de atributos pré-definidos
            //* membro da robotica (mago): 2 de inteligencia e 1 de força
            //* campeao do interclasse (dps): 2 de força e 1 de resistencia
            //* genio do clash (equilibrada): 1 de inteligencia, 1 de força e 1 de resistencia

            switch (escolha) {
                case 1:
                   intel += 2;
                   forca++;
                break;
                case 2:
                   forca += 2;
                   resist++;
                break;
                case 3:
                   forca++;
                   resist++;
                   intel++;
                break;
            }
        } while (escolha <= 0 || escolha >= 4);

        do {        
            do {
                Console.Clear();

                Console.Write($"Você tem {pontos} pontos para distribuir entre:\n\n1- Força  2- Resistência  3- Inteligência\n\nEscolha: ");
                int.TryParse(Console.ReadLine(), out escolha);

                switch(escolha) {
                    case 1:
                    forca++; //* aumenta o dano
                    break;
                    case 2:
                    resist++; //* aumenta a vida
                    break;
                    case 3:
                    intel++; //* aumenta a mana
                    break;
                }
            } while (escolha <= 0 || escolha >= 4);
            pontos--;
        } while (pontos > 0);

        vida += 5 * resist;
        mana += 5 * intel;
    }

    static void Combate2 () {
        int vidaGPT = 120, dano, acaogpt, escolha, resposta;

        Random random = new Random();

        while (vidaGPT > 0) {
            acaogpt = random.Next(1, 8); //* decide aleatorio o codigo que o player tem que corrigir
            resposta = random.Next(1, 4); //* decide aleatorio a resposta do codigo

            Console.Clear();

            Console.WriteLine($"Vida: {vida}\nVida ChatGPT: {vidaGPT}");

            switch (acaogpt) {
                case 1:
                    Console.WriteLine("O que falta no código?\n\nConsole.WriteLine('Olá Mundo!!')\n");
                    switch(resposta) {
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
                    int.TryParse(Console.ReadLine(), out escolha);
                    if (escolha == resposta) {
                        dano = random.Next(1, 16);
                        Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                        Console.ReadLine();
                        vidaGPT -= dano;
                    } else {
                        dano = random.Next(1, 11);
                        Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                        Console.ReadLine();
                        vida -= dano;
                    }
                break;
                case 2:
                    Console.WriteLine("Como corrigir o código?\n\nif (i >= 5 or i <= 10) {}\n");
                    switch(resposta) {
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
                    int.TryParse(Console.ReadLine(), out escolha);
                    if (escolha == resposta) {
                        dano = random.Next(1, 16);
                        Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                        Console.ReadLine();
                        vidaGPT -= dano;
                    } else {
                        dano = random.Next(1, 11);
                        Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                        Console.ReadLine();
                        vida -= dano;
                    }
                break;
                case 3:
                    Console.WriteLine("O que falta no código?\n\nfor (int i; i <= 10; i++) {}\n");
                    switch(resposta) {
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
                    int.TryParse(Console.ReadLine(), out escolha);
                    if (escolha == resposta) {
                        dano = random.Next(1, 16);
                        Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                        Console.ReadLine();
                        vidaGPT -= dano;
                    } else {
                        dano = random.Next(1, 11);
                        Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                        Console.ReadLine();
                        vida -= dano;
                    }
                break;
                case 4:
                    Console.WriteLine("O que falta no código?\n\nstring nome = Bruno;\n");
                    switch(resposta) {
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
                    int.TryParse(Console.ReadLine(), out escolha);
                    if (escolha == resposta) {
                        dano = random.Next(1, 16);
                        Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                        Console.ReadLine();
                        vidaGPT -= dano;
                    } else {
                        dano = random.Next(1, 11);
                        Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                        Console.ReadLine();
                        vida -= dano;
                    }
                break;
                case 5:
                    Console.WriteLine("O que está de errado com o código?\n\nConsole.ReadLine(nome);\n");
                    switch(resposta) {
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
                    int.TryParse(Console.ReadLine(), out escolha);
                    if (escolha == resposta) {
                        dano = random.Next(1, 16);
                        Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                        Console.ReadLine();
                        vidaGPT -= dano;
                    } else {
                        dano = random.Next(1, 11);
                        Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                        Console.ReadLine();
                        vida -= dano;
                    }
                break;
                case 6:
                    Console.WriteLine("O que está de errado com o código?\n\nint nome;\nnome = Console.ReadLine();\n");
                    switch(resposta) {
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
                    int.TryParse(Console.ReadLine(), out escolha);
                    if (escolha == resposta) {
                        dano = random.Next(1, 16);
                        Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                        Console.ReadLine();
                        vidaGPT -= dano;
                    } else {
                        dano = random.Next(1, 11);
                        Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                        Console.ReadLine();
                        vida -= dano;
                    }
                break;
                case 7:
                    Console.WriteLine("O que falta com o código?\n\nConsole.WriteLine('O nome digitado é: {nome}');");
                    switch(resposta) {
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
                    int.TryParse(Console.ReadLine(), out escolha);
                    if (escolha == resposta) {
                        dano = random.Next(1, 16);
                        Console.Write($"Você corrigiu o código e deu {dano} de dano!");
                        Console.ReadLine();
                        vidaGPT -= dano;
                    } else {
                        dano = random.Next(1, 11);
                        Console.Write($"Tu não corrigiu os código e o Chagas deu esporro, tu tomou {dano} de dano");
                        Console.ReadLine();
                        vida -= dano;
                    }
                break;
            }
        }

        Console.Clear();

        Console.Write($"Parabéns {nome}!! Você ganhou do Chat GPT");
    }
}