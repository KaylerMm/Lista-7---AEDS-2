class Queue
{
    private File[] array;
    private int front;
    private int rear;
    private int size;

    public Queue(int capacity)
    {
        array = new File[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void Enqueue(File item)
    {
        if (size == array.Length)
        {
            return;
        }
        rear = (rear + 1) % array.Length;
        array[rear] = item;
        size++;
    }

    public File Dequeue()
    {
        if (size == 0)
        {
            return null;
        }
        File item = array[front];
        front = (front + 1) % array.Length;
        size--;
        return item;
    }

    public int Count()
    {
        return size;
    }

    public File Peek()
    {
        if (size == 0)
            return null;
        return array[front];
    }
}
