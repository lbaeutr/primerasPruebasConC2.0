namespace PrimerContactoC2.Items.Protection;

public class Shield : Protection
{
    public Shield(String name, int armor) :
        base(name, armor) //la palabra clave base se utiliza para referirse a la clase padre y pasarle argumentos
    {
    }

 

    public override string ToString()
    {
        return $"Shield:{Name} and Armor: {Armor}";
    }
}