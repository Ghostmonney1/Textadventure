using System.Runtime.CompilerServices;

class Inventory
{
    // fields
    private int maxWeight;
    private Dictionary<string, Item> items;

    //constructer
    public Inventory(int maxWeight)
    {
        this.maxWeight = maxWeight;
        this.items = new Dictionary<string, Item>();
    }
    
    //methods
    public bool Put(string itemName, Item item)
    {
        // TODO implement:
        // Check the Weight of the Item and check
        //  for enough space in the Inventory
        // Does the Item fit?

        // Put Item in the items Dictionary
        items.Add(itemName, item);
        // Return true/false for success/failure
        return true;
    }
    public Item Get(string itemName)
    {
        // TODO implement:
        // Find Item in items Dictionary
        // remove Item from items Dictionary if found
        // return Item or null

        return null;
    }
    
    public int TotalWeight()
    {
        int total = 0;
        // TODO implement:
        // loop through the items, and add all the weights
        return total;
    }

    public int FreeWeight()
    {
        // TODO implement:
        // compare MaxWeight and TotalWeight()
        return 0;
    }
    public string Show()
    {
       
        foreach (var Key in items.Keys)
        {
            // Console.WriteLine(Key);
            return Key;
        }
    
        return "";        
    }

    

}
