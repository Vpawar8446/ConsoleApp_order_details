using System;

namespace ConsoleApp_order_details
{
    class Product
    {
        public void PrintOrderDetails(string sellername, int ordernum, string productname)
        {
            
            Console.WriteLine(" \t {0} \t\t {1} \t {2}", sellername, ordernum, productname);
            
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Product obj = new Product();
            Product obj2 = new Product();
            
            Console.Write("Enter the Seller name :");
            string sellername = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the Product name :");
            string productname = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the Order Number :");
            int ordernum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t Seller_Name Order_Num Product_Name");
            Console.WriteLine("\t =====================================");
            obj.PrintOrderDetails(sellername, ordernum, productname);
            obj.PrintOrderDetails(sellername:" PQR", productname:" PR", ordernum:14);
            
        }
    }
}
