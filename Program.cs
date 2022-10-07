
Player Player = new Player("Hero");
Monster Monster = new Monster("Monster");

Interaction Interaction = new Interaction();
Interaction.Fight(Player, Monster);

interface ICharacter
{
    string Name { get; set; }
    int Hp { get; set; }

    void Speak();
    void Move();

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

    public Monster(string name)
    {
        this.Name = name;
        this.Hp = 100;
    }

}

class Interaction
{
    public void Fight(ICharacter opponent1, ICharacter opponent2)
    {
        Console.WriteLine("The fight is on!");

        int opponent1Hp = opponent1.Hp;
        int opponent2Hp = opponent2.Hp;

        while (opponent1Hp > 0 && opponent2Hp > 0)
        {
            int opponent1Damage = Damage();
            int opponent2Damage = Damage();

            if (opponent1Damage > opponent2Damage)
                opponent2Hp -= opponent1Damage;

            else
                opponent1Hp -= opponent2Damage;
        }

        if (opponent1Hp > opponent2Hp)
            Console.WriteLine(opponent1 + " is victorious!");

        else
            Console.WriteLine(opponent2 + " is victorious!");
    }

    protected int Damage()
    {
        int damage;

        Random random = new Random();
        damage = random.Next(10, 40);

        return damage;
    }
}
