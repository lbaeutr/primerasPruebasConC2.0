using PrimerContactoC2;
using PrimerContactoC2.Items.Protection;
using PrimerContactoC2.Items.Weapons;
using PrimerContactoC2.Perks;

class Program
{
    static void Main(string[] args)
    {
        
        // Create a character
        Character hero = new Character("Ketama", 100, 10, 5);

        // Create items
        Sword sword = new Sword("Excalibur", 10);
        Helmet helmet = new Helmet("Iron Helmet", 10);
        Shield shield = new Shield("Wooden Shield", 10);
        Console.WriteLine("*****************************************************");
        
        // Display character stats
        Console.WriteLine(hero);
        Console.WriteLine("*****************************************************");

        // Equip items
        sword.Apply(hero);
        helmet.Apply(hero);
        shield.Apply(hero);

        // Apply perks Ketama
        Perks.AppllyHealthHitPoints(hero);// +50
        Perks.ApplyHealthPerk(hero);// +10
        Perks.ApplyDamagePerk(hero);//+10
        Perks.ApplyArmorPerk(hero);//+10
        
        // Apply perks items;
        Perks.ApplyArmorPerk(helmet);// +10
        Perks.ApplyArmorPerk(shield);// +10
        Console.WriteLine("*****************************************************");

        // Display updated character stats
        Console.WriteLine(hero);
        Console.WriteLine("*****************************************************");

        // Display items
        Console.WriteLine(sword);
        Console.WriteLine(helmet);
        Console.WriteLine(shield);
        
        // Supporting Characters
        SupportingCharacters supportingCharacters0 = new SupportingCharacters();
        SupportingCharacters supportingCharacters1 = new SupportingCharacters("Gotblin");
        Console.WriteLine(supportingCharacters0);
        Console.WriteLine(supportingCharacters1);
        Console.WriteLine("*****************************************************");
        
        // Delegated use
        // Nos suscribimos al evento [delegate + static event]
        Perks.OnAttack += Perks.ApplyWeaponsPerkAndMinions;
        //Disparamos el evento del ataque, aplicando el daño de la espada y el daño del minion
        Perks.InvokeAttack(hero ,sword, supportingCharacters0);








    }
}