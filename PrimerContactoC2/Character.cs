using PrimerContactoC2.Items;
using PrimerContactoC2.Items.Weapons;
using PrimerContactoC2.Perks;


namespace PrimerContactoC2;

public class Character
{
    public string Name { get; set; }

    public int Level { get; set; } //todo mirar

    public int Experience { get; set; } //todo mirar

    public int MagicPoints { get; set; } //todo mirar
    public int CurrentHitPoints { get; set; }
    public int MaxHitPoints { get; set; }
    public int BaseDamage { get; set; }
    public int BaseArmor { get; set; }

    private List<IItem> _invetory = new List<IItem>();
    private List<SupportingCharacters> _supportingCharacters = new List<SupportingCharacters>();

    public Character(string name, int hitPoints, int damage, int armor)
    {
        Name = name;
        CurrentHitPoints = hitPoints;
        MaxHitPoints = hitPoints;
        BaseDamage = damage;
        BaseArmor = armor;
    }

    public int Attack()
    {
        return BaseDamage;
    }

    public int Defense()
    {
        return BaseArmor;
    }

    public void Heal(int points)
    {
        CurrentHitPoints += points;
        if (CurrentHitPoints > MaxHitPoints)
        {
            CurrentHitPoints = MaxHitPoints;
        }
    }

    public void ReceiveDamage(int points) // todo podemos ver si metemos la armadura
    {
        CurrentHitPoints -= points;
        if (CurrentHitPoints < 0)
        {
            CurrentHitPoints = 0;
        }
    }

    public void AddItem(IItem item) //TODO podemos ver el sistema de perks al implementar el sistema de items
    {
        _invetory.Add(item);
    }

    public void RemoveItem(IItem item) // TODO podemos quitar las ayudas de las implementaciones de los items
    {
        _invetory.Remove(item);
    }

    public void ShowInventory()
    {
        foreach (var item in _invetory)
        {
            Console.WriteLine(item);
        }
    }

    public void AddSupportingCharacter(SupportingCharacters supportingCharacters)
    {
        _supportingCharacters.Add(supportingCharacters);
    }

    public void RemoveSupportingCharacter(SupportingCharacters supportingCharacters)
    {
        _supportingCharacters.Remove(supportingCharacters);
    }

    public void ShowSupportingCharacters()
    {
        foreach (var supportingCharacter in _supportingCharacters)
        {
            Console.WriteLine(supportingCharacter);
        }
    }

    public override string ToString()
    {
        return $"{Name} - Vida: {CurrentHitPoints}/{MaxHitPoints} - Daño: {BaseDamage} - Armadura: {BaseArmor}";
    }
}