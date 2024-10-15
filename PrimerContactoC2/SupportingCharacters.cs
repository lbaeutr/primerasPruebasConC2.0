namespace PrimerContactoC2;

public class SupportingCharacters
{
    
    public  delegate void Supporting(Character character);// todo delegado para personajes de apoyo????????????????
    public string Name { get; set; }
    public int CurrentHitPoints { get; set; }
    public int MaxHitPoints { get; set; }
    public int BaseDamage { get; set; }
    public int BaseArmor { get; set; }


    public SupportingCharacters() // invocacion de elementos skeleton , que son subditos que  podremos usar en el juego por defecto
    {
        Name ="Skeleton";
        CurrentHitPoints = 100;
        MaxHitPoints = 100;
        BaseDamage = 15;
        BaseArmor = 50;   
    }


    public SupportingCharacters(string name)// Constructor por defecto , invocaciones
    {
        Name = name;
        CurrentHitPoints = 100;
        MaxHitPoints = 100;
        BaseDamage = 15;
        BaseArmor = 50;
    }
    
    public SupportingCharacters(string name, int hitPoints, int damage, int armor) // Constructor por si queremos invocaciones + poderosas.
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
    
    public void ReceiveDamage(int points) // todo podemos ver si metemos la armadura como en la clase character
    {
        CurrentHitPoints -= points;
        if (CurrentHitPoints < 0)
        {
            CurrentHitPoints = 0;
        }    }

    public override string ToString()
    {
        return  $"Name del SupportingCharacters: {Name} - Daño: {BaseDamage} - Armadura: {BaseArmor}";
    }
}