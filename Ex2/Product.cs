class Product
{
    private string name;
    private int quantity;
    private double price;

    public Product(string name, int quantity, double price)
    {
        this.name = name;
        this.quantity = quantity;
        this.price = price;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public override string ToString()
    {
        return $"[nome: {name}, quantidade: {quantity}, preco: {price}]";
    }
}