using System;


public class Player
{
    public int Health { get; set; }
    public int Damage { get; set; }

    
    public void InvertControls()
    {
        
    }
}


public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Action<Player> UseItem { get; set; }

    
    public Item(string name, string description, Action<Player> useItem)
    {
        Name = name;
        Description = description;
        UseItem = useItem;
    }

    
    public void ApplyEffect(Player player)
    {
        UseItem(player);
    }
}


public class Game
{
    public static void Main(string[] args)
    {
        
        Player player = new Player { Health = 100, Damage = 10 };

        
        Item healingPotion = new Item(
            "Poção de Cura", 
            "Restaura 20 pontos de vida", 
            player => player.Health += 20
        );

        
        Item strengthPotion = new Item(
            "Poção de Força", 
            "Aumenta o dano por 3 turnos", 
            player => player.Damage += 5
        );

        
        Item poisonPotion = new Item(
            "Veneno", 
            "Reduz 10 pontos de vida", 
            player => player.Health -= 10
        );

        
        Item confusionPotion = new Item(
            "Poção de Confusão", 
            "Inverte os controles do jogador", 
            player => player.InvertControls()
        );

        
        healingPotion.ApplyEffect(player);
        strengthPotion.ApplyEffect(player);
        poisonPotion.ApplyEffect(player);
        confusionPotion.ApplyEffect(player);

        
        Console.WriteLine($"Vida do jogador: {player.Health}");
        Console.WriteLine($"Dano do jogador: {player.Damage}");
    }
}
