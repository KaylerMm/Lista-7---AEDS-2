using System;

class Program
{
    static void Main(string[] args)
    {
        List productList = new List(100);

        bool running = true;
        while (running)
        {
            Console.WriteLine("1) Inserir um produto no final da lista.");
            Console.WriteLine("2) Remover um produto especifico da lista.");
            Console.WriteLine("3) Listar os dados de todos os produtos da lista.");
            Console.WriteLine("4) Pesquisar se um produto ja consta na lista.");
            Console.WriteLine("5) Sair");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Digite o nome do produto:");
                string name1 = Console.ReadLine();
                Console.WriteLine("Digite a quantidade:");
                int quantity1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o preco:");
                double price1 = double.Parse(Console.ReadLine());
                Product product1 = new Product(name1, quantity1, price1);
                productList.InsertAtEnd(product1);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Digite o nome do produto a remover:");
                string name2 = Console.ReadLine();
                Product removedProduct = productList.RemoveItem(name2);
                if (removedProduct == null)
                    Console.WriteLine("Produto nao encontrado na lista.");
            }
            else if (choice == 3)
            {
                productList.ListProducts();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Digite o nome que deseja pesquisar:");
                string name4 = Console.ReadLine();
                productList.Search(name4);
            }
            else if (choice == 5)
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
