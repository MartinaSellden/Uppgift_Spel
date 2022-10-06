
interface ICharacter
{
    string Name { get; set;}
    int Hp { get; set;}

    void Speak();
    void Move();
}

class Player : ICharacter
{
    public string Name { get; set; }

    public int Hp { get; set; }

    public void Speak()
    {
        throw new NotImplementedException();
    }
    public void Move()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }
    public void Move()
    {
        throw new NotImplementedException();
    }

    public Monster(string name)
    {
        this.Name = name;
        this.Hp = 100;
    }

}