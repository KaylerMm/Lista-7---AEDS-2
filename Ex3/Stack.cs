using System.Collections;
class Stack
{
    private char[] array;
    private int top;

    public Stack(int capacity)
    {
        array = new char[capacity];
        top = -1;
    }

    public void Push(char item)
    {
        if (top == array.Length - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }
        top++;
        array[top] = item;
    }

    public char Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return '\0';
        }
        char item = array[top];
        top--;
        return item;
    }

    public int Count()
    {
        return top + 1;
    }
}
