public class Enemy{
    // fields
    public string Name;
    public int Health;
    public List <string> AttackList;


    //constructor 
    public Enemy(string name)
    {
        Name=name;
        Health=100;
        AttackList= new List<string>();
    }


    //method-Show Info
    //testing
    public void ShowInfo()
    {   Console.WriteLine ("*************");
        Console.WriteLine ($"Enemy Name:{Name}");
        Console.WriteLine ($"Health:{Health}");
        foreach(string a in AttackList){
            Console.WriteLine(a);
        }
    }
    //methods-RandomAttack from AttackList
    public void RandomAttack()
    {
        Random rand=new Random();
        int randIndex= rand.Next(0,AttackList.Count);
        Console.WriteLine($"Random Attack:{AttackList[randIndex]}");
    }
}