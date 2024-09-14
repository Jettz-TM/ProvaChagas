using System;

namespace Jogo
{
	// Definição da classe Player
	public class Player
	{
    	public int Health { get; set; }
    	public int Damage { get; set; }
    	public bool IsConfused { get; set; } // Adiciona um status para confusão

    	public Player()
    	{
        	Health = 100;
        	Damage = 10;
        	IsConfused = false;
    	}

    	// Exemplo de método para inverter controles
    	public void InvertControls()
    	{
        	IsConfused = true;
        	Console.WriteLine("Os controles do jogador foram invertidos!");
    	}

    	// Método para restaurar os controles
    	public void RestoreControls()
    	{
        	IsConfused = false;
        	Console.WriteLine("Os controles do jogador foram restaurados!");
    	}
	}

	// Definição da classe Item
	public class Item
	{
    	public string Name { get; set; }
    	public string Description { get; set; }
    	public Action<Player> UseItem { get; set; }

    	// Construtor da classe Item
    	public Item(string name, string description, Action<Player> useItem)
    	{
        	Name = name;
        	Description = description;
        	UseItem = useItem;
    	}

    	// Método para aplicar o efeito no jogador
    	public void ApplyEffect(Player player)
    	{
        	UseItem(player);
    	}
	}

	// Exemplo de uso dos itens
	public class Game
	{
    	public static void Main(string[] args)
    	{
        	// Criação de um jogador
        	Player player = new Player();

        	// Criação e uso da poção de cura
        	Item healingPotion = new Item(
            	"Poção de Cura",
            	"Restaura 20 pontos de vida",
            	player => player.Health += 20
        	);

        	// Criação e uso da poção de força
        	Item strengthPotion = new Item(
            	"Poção de Força",
            	"Aumenta o dano por 3 turnos",
            	player => player.Damage += 5 // Aplicar lógica para 3 turnos seria necessário
        	);

        	// Criação e uso da poção de veneno
        	Item poisonPotion = new Item(
            	"Veneno",
            	"Reduz 10 pontos de vida",
            	player => player.Health -= 10
        	);

        	// Criação e uso da poção de confusão
        	Item confusionPotion = new Item(
            	"Poção de Confusão",
            	"Inverte os controles do jogador",
            	player => player.InvertControls()
        	);

        	// Aplicando os efeitos dos itens
        	healingPotion.ApplyEffect(player);
        	strengthPotion.ApplyEffect(player);
        	poisonPotion.ApplyEffect(player);
        	confusionPotion.ApplyEffect(player);

        	// Exibir os resultados
        	Console.WriteLine($"Vida do jogador: {player.Health}");
        	Console.WriteLine($"Dano do jogador: {player.Damage}");

        	// Restaurar controles após algum tempo ou condição
        	player.RestoreControls();
    	}
	}
}
