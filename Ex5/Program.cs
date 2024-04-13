using System;
class Program
{
    static void Main(string[] args)
    {
        Queue printQueue = new Queue(100);

        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Inserir arquivo na fila de impressao");
            Console.WriteLine("2. Executar impressao");
            Console.WriteLine("3. Exibir fila de impressao");
            Console.WriteLine("4. Sair");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Digite o nome do arquivo:");
                string fileName = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de paginas:");
                int pages = int.Parse(Console.ReadLine());
                File newFile = new File(fileName, pages);
                printQueue.Enqueue(newFile);
            }
            else if (choice == 2)
            {
                printQueue.Dequeue();
            }
            else if (choice == 3)
            {
                for (int i = 0; i < printQueue.Count(); i++)
                {
                    File temp = printQueue.Peek();
                    Console.WriteLine("nome: " + temp.GetName() + ", numero paginas: " + temp.GetPages());
                    printQueue.Enqueue(printQueue.Dequeue());
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("O programa sera encerrado.");
                running = false;
            }
            else
            {
                Console.WriteLine("Opcao invalida. Por favor, escolha novamente.");
            }
        }
    }
}
