namespace PrimerContactoC2.Items.Protection;

public class Helmet : Protection
{
    public Helmet(string name, int armor) : base(name, armor)
    {
    }



    public override string ToString()
    {
        return $"Helmet:{Name} and Armor: {Armor}";
    }
}