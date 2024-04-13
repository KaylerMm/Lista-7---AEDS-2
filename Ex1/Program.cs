using System;

class Program
{
    static void Main(string[] args)
    {
        List marathonTimes = new List(100);

        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Inserir um tempo no inicio da lista.");
            Console.WriteLine("2) Inserir um tempo no final da lista.");
            Console.WriteLine("3) Inserir um tempo numa posicao especifica da lista.");
            Console.WriteLine("4) Remover o primeiro tempo da lista.");
            Console.WriteLine("5) Remover o ultimo tempo da lista.");
            Console.WriteLine("6) Remover um tempo de uma posicao especifica na lista.");
            Console.WriteLine("7) Remover um tempo especifico da lista.");
            Console.WriteLine("8) Pesquisar quantas vezes um determinado tempo consta na lista.");
            Console.WriteLine("9) Mostrar todos os tempos da lista.");
            Console.WriteLine("10) Encerrar o programa.");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Informe o tempo:");
                double time1 = double.Parse(Console.ReadLine());
                marathonTimes.InsertAtStart(time1);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Informe o tempo:");
                double time2 = double.Parse(Console.ReadLine());
                marathonTimes.InsertAtEnd(time2);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Informe o tempo:");
                double time3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a posicao:");
                int position3 = int.Parse(Console.ReadLine());
                marathonTimes.InsertAtPosition(time3, position3);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Tempo removido: " + marathonTimes.RemoveFirst() + ".");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Tempo removido: " + marathonTimes.RemoveLast() + ".");
            }
            else if (choice == 6)
            {
                Console.WriteLine("Informe a posicao:");
                int position6 = int.Parse(Console.ReadLine());
                Console.WriteLine("Tempo removido: " + marathonTimes.RemoveAtPosition(position6) + ".");
            }
            else if (choice == 7)
            {
                Console.WriteLine("Informe o tempo a remover:");
                double time7 = double.Parse(Console.ReadLine());
                Console.WriteLine("Tempo removido: " + marathonTimes.RemoveItem(time7) + ".");
            }
            else if (choice == 8)
            {
                Console.WriteLine("Informe o tempo:");
                double time8 = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade: " + marathonTimes.Count(time8));
            }
            else if (choice == 9)
            {
                marathonTimes.ShowAllTimes();
            }
            else if (choice == 10)
            {
                Console.WriteLine("O programa sera encerrado.");
                running = false;
            }
            else
            {
                Console.WriteLine("Escolha invalida. Por favor, tente novamente.");
            }
        }
    }
}
