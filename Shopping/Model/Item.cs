public class Item
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
    public Item(string Name = "",
                int Quantity = 0,
                float Price = 0)
    {
        this.Name = Name;
        this.Quantity = Quantity;
        this.Price = Price;
    }
}


