class Player
{
    // fields
    private int health = 100;

    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    
    //auto property
    public Room CurrentRoom { get; set; }

    //constructor
    public Player()
    {
        CurrentRoom = null;
        health = 100;

    }

    public bool IsHurt()
    {
        return true;
    }
   public int Damage(int amount)
    {
        health -= amount;
        return health;
    }
    // player loses some health
    public int Heal(int amount)
    {
        health += amount;
        return health;
    }
    // player's health restores
    public bool IsAlive()
    {
        if (health <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}



