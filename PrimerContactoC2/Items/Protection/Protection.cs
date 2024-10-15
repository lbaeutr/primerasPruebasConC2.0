namespace PrimerContactoC2.Items.Protection;

public abstract class Protection : IItem
{
    public string Name { get; set; }
    public int Armor { get; set; }

    public Protection(string name, int armor)
    {
        this.Name = name;
        this.Armor = armor;
    }

    public virtual void Apply(Character character)
    {
        Console.WriteLine($"{character.Name} equips {Name}, increasing armor  by {Armor}.");
        character.BaseArmor += Armor;
    }

    public int GetArmor()
    {
        return Armor;
    }

    public override string ToString()
    {
        return $"{Name} and Armor: {Armor}";
    }
}