namespace PrimerContactoC2.Items.Weapons;

public class Sword : Weapons
{
    public Sword(string name, int damage) : base(name, damage)
    {
    }

    public override string ToString()
    {
        return $"Sword: {Name} - Daño: {Damage}";
    }
}