using PrimerContactoC2.Items.Protection;
using PrimerContactoC2.Items.Weapons;

namespace PrimerContactoC2.Perks;
//todo mirar

public static class Perks
{
    public delegate void
        DelegateWeaponSupport(Character character, Weapons weapon,
            SupportingCharacters supportingCharacters); //todo delegado 

    public static event DelegateWeaponSupport OnAttack; // EVENTO PARA ATACAR.


    //BENEFICIOS DEL PERSONAJE

    /*
     * Mejora de Puntos de Vida
     */
    public static void ApplyHealthPerk(Character character)
    {
        character.CurrentHitPoints += 10;
    }

    public static void ApplyHealthPerkCancel(Character character)
    {
        character.CurrentHitPoints -= 10;
    }

    public static void AppllyHealthHitPoints(Character character)
    {
        character.MaxHitPoints += 50;
    }

    public static void AppllyHealthHitPointsCancel(Character character)
    {
        character.MaxHitPoints -= 50;
    }

    /*
     * Mejora de Daño
     */
    public static void ApplyDamagePerk(Character character)
    {
        character.BaseDamage += 10;
    }

    public static void ApplyDamagePerkCancel(Character character)
    {
        character.BaseDamage -= 10;
    }

    /*
     * Mejora de Armadura Personaje
     */
    public static void ApplyArmorPerk(Character character)
    {
        character.BaseArmor += 10;
    }

    public static void ApplyArmorPerkCancel(Character character)
    {
        character.BaseArmor -= 10;
    }

    /*
     * Para los beneficios de armas
     */

    public static void ApplyWeaponsPerk(Weapons weapon)
    {
        weapon.Damage += 50;
    }

    public static void ApplyWeaponsPerkCancel(Weapons weapon)
    {
        weapon.Damage -= 50;
    }


    /*
     * Para los beneficios de armadura
     */

    public static void ApplyArmorPerk(Protection armor)
    {
        armor.Armor += 10;
    }

    public static void ApplyArmorPerkCancel(Protection armor)
    {
        armor.Armor += 10;
    }
    /*
     * Para los beneficios de minions
     */


    public static void ApplyDamageMinionPerk(SupportingCharacters subdito) //todo ponerlos individualmente
    {
        subdito.BaseDamage += 50;
    }

    public static void ApplyDamageMinionPerkCancel(SupportingCharacters subdito) //todo ponerlos individualmente
    {
        subdito.BaseDamage -= 50;
    }

    public static void ApplyArmorMinionPerk(SupportingCharacters subdito) //todo ponerlos individualmente
    {
        subdito.BaseArmor += 10;
    }

    public static void ApplyArmorMinionPerkCancel(SupportingCharacters subdito) //todo ponerlos individualmente
    {
        subdito.BaseArmor -= 10;
    }
    

    /*
     * Para los beneficios de armas y minions
     */
    public static void ApplyWeaponsPerkAndMinions(Character character, Weapons weapon,
        SupportingCharacters supportingCharacters)
    {
        character.Attack();
        supportingCharacters = new SupportingCharacters();
        Console.WriteLine(
            $"Ataque de {weapon.Name}  invocando un nuevo subdito {supportingCharacters.Name}.. ");
        supportingCharacters.Attack();
    }

    public static void InvokeAttack(Character character, Weapons weapon, SupportingCharacters supportingCharacter)
    {
        OnAttack?.Invoke(character, weapon, supportingCharacter); // Dispara el evento si alguien está suscrito
    }
}