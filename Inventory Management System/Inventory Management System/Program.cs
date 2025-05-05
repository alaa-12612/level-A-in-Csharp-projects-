using System.Xml.Linq;

namespace Inventory_Management_System
{
    internal class Program
    {

        const int numberofProduct = 50;

        static string[,] inventory = new string[numberofProduct, 4];

        static int ProductCount = 0;
        static void Main(string[] args)
        {
            //Add product
            //Update product
            //View product( ID, NAME,QUANTITY , PRICE )
            // Exit

            while (true)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine(" ** welcome to our inventory system **");
            Console.WriteLine("===========================================");
            Console.WriteLine(" Enter your Choice");
            Console.WriteLine("===========================================");

            Console.WriteLine(" 1- Add product ");

            Console.WriteLine(" 2- Update product ");

            Console.WriteLine(" 3- View product ");

            Console.WriteLine(" 4- Exit ");

            Console.WriteLine("===========================================");

            int Choice =Convert.ToInt32(Console.ReadLine());
       
                switch (Choice)
                {
                    case 1:
                        //add product 
                        AddProduct();
                        break;

                    case 2:
                        //update product 
                        updateProduct();
                        break;

                    case 3:
                        //View product
                        ViewProduct();
                     break;

                    case 4:
                        //Exit
                        Environment.Exit(0);
                        break;

                }
            }

        }

        private static void AddProduct()
        {
            Console.WriteLine("Enter product name ");
            string name = Console.ReadLine();
            Console.WriteLine("----------------------");

            Console.WriteLine("Enter product quantity ");
            string quantity =Console.ReadLine();
            Console.WriteLine("----------------------");

            Console.WriteLine("Enter product price ");
            string price  = Console.ReadLine();
            Console.WriteLine("----------------------");

            inventory[ProductCount, 0] = name;
            inventory[ProductCount, 1] = quantity;
            inventory[ProductCount, 2] = price;

             ProductCount++;

            Console.WriteLine(" product add successfully ");
        }

        private static void ViewProduct()
        {
            if (ProductCount>0)
            {
                Console.WriteLine("product list");

            }
            for (int i=0;i< ProductCount;i++)
            {
                Console.WriteLine($" product ID :{i} , product Name :{inventory[i, 0]} ,product quantity: {inventory[i, 1]},product price :{inventory[i, 2]}");


            }
        }
        private static void updateProduct()
        {
            Console.WriteLine("Enter the item you want to change ");
            Console.WriteLine("-------------------------------------");
            string searchproduct = Console.ReadLine();

            int productID = -1;

            if (ProductCount > 0)
            {
                for (int i = 0; i < ProductCount; i++)
                {
                    if (inventory[i, 0] == searchproduct)
                    {
                        productID = i;
                        break;
                    }
                }

                if (productID != -1)
                {
                    Console.WriteLine("Enter new quantity ");
                    Console.WriteLine("-------------------------------------");

                    string newquantity = Console.ReadLine();

                    inventory[productID, 1] = newquantity;

                    Console.WriteLine("Quantity updated successfully ");
                }
                
            }

            else
            {
                Console.WriteLine("Product not found!");
            }
        }

    }
}
