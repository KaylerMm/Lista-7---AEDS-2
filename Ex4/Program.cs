using System;

class Program
{
    static void Main(string[] args)
    {
        Queue runwayQueue = new Queue(5);

        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Listar a quantidade de avioes que estao aguardando na fila de decolagem.");
            Console.WriteLine("2.Autorizar a decolagem do primeiro aviao da fila de decolagem.");
            Console.WriteLine("3.Adicionar um aviao na fila de colagem.");
            Console.WriteLine("4.Listar todos os avioes que estao na fila de colagem.");
            Console.WriteLine("5.Exibir o primeiro aviao da fila de colagem.");
            Console.WriteLine("6.Sair");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Quantidade de avioes: " + runwayQueue.Count() + ".");
                    break;
                case 2:
                    string dequeuedPlane = runwayQueue.Dequeue();
                    if (dequeuedPlane != null)
                        Console.WriteLine("O aviao " + dequeuedPlane + " decolou.");
                    break;
                case 3:
                    Console.WriteLine("Digite o identificador do aviao:");
                    string plane = Console.ReadLine();
                    runwayQueue.Enqueue(plane);
                    break;
                case 4:
                    Console.Write("[ ");
                    for (int i = 0; i < runwayQueue.Count(); i++)
                    {
                        Console.Write(runwayQueue.Peek() + " ");
                        string temp = runwayQueue.Dequeue();
                        runwayQueue.Enqueue(temp);
                    }
                    Console.WriteLine("]");
                    break;
                case 5:
                    Console.WriteLine("Primeiro aviao da fila: " + runwayQueue.Peek());
                    break;
                case 6:
                    Console.WriteLine("O programa sera encerrado!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opcao invalida. Por favor, escolha novamente.");
                    break;
            }
        }
    }
}
