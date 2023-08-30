Enemy enemy1 =new Enemy("Bandit");
Enemy enemy2= new Enemy("Boss");
Enemy enemy3= new Enemy("Guard");

List<Enemy> AllEnemies= new List<Enemy>();
AllEnemies.Add(enemy1);
AllEnemies.Add(enemy2);
AllEnemies.Add(enemy3);


//confirming the enemy instances were created
foreach(Enemy e in AllEnemies)
{
    e.ShowInfo();
}

//added 3 attacks to enemy1;
enemy1.AttackList.Add("fireball");
enemy1.AttackList.Add("punch");
enemy1.AttackList.Add("throw");

enemy1.ShowInfo();
enemy1.RandomAttack();

//fireball damage=20; pnch/throw=between 5-25;
//create 3 instances of attacks: fireball, punch, throw
Attack attack1= new Attack("fireball", 20);
Attack attack2= new Attack("punch", 10);
Attack attack3= new Attack("throw", 15);

//Created an Attacks List to confirm instances of Attack
List<Attack> AllAttacks= new List<Attack>();
AllAttacks.Add(attack1);
AllAttacks.Add(attack2);
AllAttacks.Add(attack3);

foreach(Attack a in AllAttacks)
{
    a.ShowInfo();
}