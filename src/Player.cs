class Player
{
    // fields
    private int health = 100;
    public Inventory Backpack
    {
        get; set;
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    private Inventory backpack;
    
    
    
    //auto property
    public Room CurrentRoom { get; set; }

    //constructor
    public Player()
    {
        CurrentRoom = null;
        health = 100;

        // 25kg is pretty heavy to carry around all day.
        Backpack = new Inventory(25); 

    }
    
    // methods
    public bool TakeFromChest(string itemName)
    {
        // TODO implement:
        // Remove the Item from the Room
        // Put it in your backpack.
        // Inspect returned values.
        // If the item doesn't fit your backpack, put it back in the chest.
        // Communicate to the user what's happening.
        // Return true/false for success/failure
        return false;
    }
    public bool DropToChest(string itemName)
    {
        // TODO implement:
        // Remove Item from your inventory.
        // Add the Item to the Room
        // Inspect returned values
        // Communicate to the user what's happening
        // Return true/false for success/failure

        return false;
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



