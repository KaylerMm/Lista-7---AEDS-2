using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack(100);

        Console.WriteLine("Informe a sequencia:");
        string sequence = Console.ReadLine();

        bool isWellFormed = CheckWellFormed(sequence, stack);

        if (isWellFormed)
            Console.WriteLine("Sequencia bem formada!");
        else
            Console.WriteLine("Sequencia mal formada!");
    }

    static bool CheckWellFormed(string sequence, Stack stack)
    {
        foreach (char c in sequence)
        {
            if (c == '(' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']')
            {
                if (stack.Count() == 0)
                    return false;

                char top = stack.Pop();

                if ((c == ')' && top != '(') || (c == ']' && top != '['))
                    return false;
            }
        }

        return stack.Count() == 0;
    }
}
