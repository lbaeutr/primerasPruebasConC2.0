namespace PrimerContactoC2.Items.Weapons;

public abstract class Weapons : IItem
{
    public string Name { get; init; }
    public int Damage { get; set; }

    public Weapons(string name, int damage)
    {
        this.Name = name;
        this.Damage = damage;
    }


    public void Apply(Character character)
    {
        Console.WriteLine($"{character.Name} equips {Name}, increasing damage by {Damage}.");
        character.BaseDamage += Damage;
    }

    public int GetDamage()
    {
        return Damage;
    }

    public override string ToString()
    {
        return $"{Name} and Damage: {Damage}";
    }
}