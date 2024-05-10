using ProdutoPolimorfismo.Entities;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product " + i + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string check = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());


                if (check == "i" || check == "I")
                {
                    Console.Write("Customs fee: ");
                    double custom = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, custom));
                }

                else if (check=="u" || check== "U")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }

                else if (check=="c" || check =="C")
                {
                    list.Add(new Product(name, price));
                }

                
            }

            foreach (Product obj in list)
            {
                Console.WriteLine(obj.PriceTag());
            }

        }
    }
}
