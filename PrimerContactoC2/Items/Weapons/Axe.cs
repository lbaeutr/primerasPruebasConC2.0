namespace PrimerContactoC2.Items.Weapons;

public class Axe : Weapons
{
    public Axe(string name, int damage) : base(name, damage)
    {
    }

    public override string ToString()
    {
        return $"Axe: {Name} - Daño: {Damage}";
    }
}