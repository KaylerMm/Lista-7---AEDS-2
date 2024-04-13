class List
{
    private double[] array;
    private int size;

    public List(int capacity)
    {
        array = new double[capacity];
        size = 0;
    }

    public void InsertAtStart(double time)
    {
        ShiftRight();
        array[0] = time;
        size++;
    }

    public void InsertAtEnd(double time)
    {
        array[size] = time;
        size++;
    }

    public void InsertAtPosition(double time, int position)
    {
        ShiftRight(position);
        array[position] = time;
        size++;
    }

    public double RemoveFirst()
    {
        double removedTime = array[0];
        ShiftLeft();
        size--;
        return removedTime;
    }

    public double RemoveLast()
    {
        double removedTime = array[size - 1];
        size--;
        return removedTime;
    }

    public double RemoveAtPosition(int position)
    {
        double removedTime = array[position];
        ShiftLeft(position);
        size--;
        return removedTime;
    }

    public double RemoveItem(double time)
    {
        int index = Array.IndexOf(array, time);
        if (index == -1)
            return -1; // Time not found
        RemoveAtPosition(index);
        return time;
    }

    public int Count(double time)
    {
        int count = 0;
        foreach (double t in array)
        {
            if (t == time)
                count++;
        }
        return count;
    }

    public void ShowAllTimes()
    {
        Console.Write("[ ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("]");
    }

    private void ShiftRight(int start = 0)
    {
        for (int i = size; i > start; i--)
        {
            array[i] = array[i - 1];
        }
    }

    private void ShiftLeft(int start = 0)
    {
        for (int i = start; i < size - 1; i++)
        {
            array[i] = array[i + 1];
        }
    }
}