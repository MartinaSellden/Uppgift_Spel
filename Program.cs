
interface ICharacter
{
    string Name { get; set;}
    int Hp { get; set;}

    void Speak();
    void Move();

    void Fight();

}


class Player : ICharacter
{
    public string Name { get; set; }

    public int Hp { get; set; }

    public void Speak()
    {
        Console.WriteLine("I'm a hero!");
    }
    public void Move()
    {
        Console.Write("Running with sword in hand!");
    }

    int Damage()
    {
        int damage;

        Random random = new Random();
        damage = random.Next(0, 20);

        return damage;
    }

    public Player(string name)
    {
       this.Name = name;
       this.Hp = 100;
    }


}

class Monster : ICharacter
{
    public string Name { get; set; }

    public int Hp { get; set; }

    public void Speak()
    {
        Console.WriteLine("Aaaaarg!");
    }
    public void Move()
    {
        Console.WriteLine("Sneaking around waiting for prey...");    
    }

    public void Fight()
    {

    }

    int Damage()
    {
        int damage;

        Random random = new Random();
        damage = random.Next(0, 20);

        return damage;
    }

    public Monster(string name)
    {
        this.Name = name;
        this.Hp = 100;
    }

}