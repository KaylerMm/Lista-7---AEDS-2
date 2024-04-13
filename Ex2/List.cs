class List
{
    private Product[] array;
    private int size;

    public List(int capacity)
    {
        array = new Product[capacity];
        size = 0;
    }

    public void InsertAtEnd(Product product)
    {
        array[size] = product;
        size++;
    }

    public Product RemoveItem(string name)
    {
        for (int i = 0; i < size; i++)
        {
            if (array[i].Name == name)
            {
                Product removedProduct = array[i];
                ShiftLeft(i);
                size--;
                return removedProduct;
            }
        }
        return null;
    }

    public void ListProducts()
    {
        Console.WriteLine("Lista de Produtos:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    public bool Search(string name)
    {
        for (int i = 0; i < size; i++)
        {
            if (array[i].Name == name)
            {
                Console.WriteLine("Produto Cadastrado.");
                return true;
            }
        }
        Console.WriteLine("Produto não Cadastrado.");
        return false;
    }

    private void ShiftLeft(int start)
    {
        for (int i = start; i < size - 1; i++)
        {
            array[i] = array[i + 1];
        }
    }
}