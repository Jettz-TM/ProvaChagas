public class item
{
    public string Name {get; set;}
    public string Description {get; set;}
    public Action<Player> UseItem;
    public item (string name, string description, Action<Player> useIten )
    Name = name;
    Description = description;
    UseItem = useiten;
    public void ApplyEffect(Player player)
    UseItem(player);
    public void Createitens()
    item healingpotion = new item("poção de cura, reastaura 20 pontos de vida", player => player.Health += 20)
    item strengthpotion = new item("poção de força, aumenta o dano por 3 turnos", player => player.Damage += 5)
    item poisonpotion = new item("veneno, reduz 10 pontos de vida", player => player.Health -= 10)
    item confusionpotion = new item("poção de confusão, reastaura 20 pontos de vida", player => player.invertControl())
    
}
