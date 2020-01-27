using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_CS_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var productList = new List<Products>();

            productList.Add(new Products() {name = "lettuce", price = 10.5f,quantity = 50,type = "Leafy green" });
            productList.Add(new Products() { name = "cabbage", price = 20f, quantity = 100, type = "Cruciferous" });
            productList.Add(new Products() { name = "pumpkin", price = 30f, quantity = 30, type = "Marrow" });
            productList.Add(new Products() { name = "cauliflower", price = 10f, quantity = 25, type = "Cruciferous" });
            productList.Add(new Products() { name = "zucchini", price = 20.5f, quantity = 50, type = "Marrow" });
            productList.Add(new Products() { name = "yam", price = 30f, quantity = 50, type = "Root" });
            productList.Add(new Products() { name = "spinach", price = 10f, quantity = 100, type = "Leafy green" });
            productList.Add(new Products() { name = "broccoli", price = 20.2f, quantity = 75, type = "Cruciferous" });
            productList.Add(new Products() { name = "garlic", price = 30f, quantity = 20, type = "Leafy green" });
            productList.Add(new Products() { name = "silverbeet", price = 10f, quantity = 50, type = "Marrow" });

            Console.WriteLine("Total products = "+productList.Count);
            Console.WriteLine();

            productList.Add(new Products() { name = "Potato", price = 10f, quantity = 50, type = "Root" });

            foreach(var pr in productList)
            {
                Console.WriteLine($"Name = {pr.name}         Price = {pr.price} Rs      Quantity = {pr.quantity}       Type = {pr.type}");
            }

            Console.WriteLine();
            Console.WriteLine($"Total Products = {productList.Count}");
            Console.WriteLine();

            foreach (var r in productList)
            {
                if (r.type.Equals("Leafy green"))
                {
                    Console.WriteLine($"Name = {r.name}      Price = {r.price} Rs        Quantity = {r.quantity}        Type = {r.type}");
                }
            }

            Console.WriteLine();

            productList.RemoveAt(8);

            Console.WriteLine("Total Products ="+productList.Count);
            Console.WriteLine();

            Console.WriteLine("add cabbages : ");
            var cab = int.Parse(Console.ReadLine());

            productList[1].quantity += cab;
            Console.WriteLine();
            Console.WriteLine("Toatl Cabbages : "+productList[1].quantity);
            Console.WriteLine();

            float sum = 0;

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the number of item You wanna Buy :");
                int i = 1;
                foreach(var vr in productList)
                {
                    Console.WriteLine("  " + i + " " + vr.name + " " + vr.price + "Rs/kg");
                    i++;
                }

                Console.WriteLine("  0  EXIT");
                Console.WriteLine();

                move:

                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                    break;
                else if (x > productList.Count)
                {
                    Console.WriteLine("Invalid Option : Please Re-Enter you item number :");
                    goto move;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("How Many Kgs :");
                    int k = int.Parse(Console.ReadLine());
                    sum += (productList[x - 1].price*k);
                    Console.WriteLine();
                }

            }

            Console.WriteLine("You need to pay : " + Math.Round(sum));

        }

    }
}
