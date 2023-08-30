public class Attack{
    // fields
    public string Name;
    public int DamageAmount;

    //constructor
    public Attack (string name, int damageAmount)
    {
        Name=name;
        DamageAmount=damageAmount;
    }

    //method show info
    public void ShowInfo()
    {   Console.WriteLine ("*************");
        Console.WriteLine ($"Attack Name:{Name}");
        Console.WriteLine ($"Damage Amount:{DamageAmount}");
    }
}