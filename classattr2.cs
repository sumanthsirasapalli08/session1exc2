using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace classattributes
{
    class Product
    {
        internal int productId;
        internal string productName;
        internal double price;
        internal string color;

        internal void Display()
        {
            Console.WriteLine("ID:" + productId + "   " + productName + "  " + price + "    " + color);
            Console.ReadLine();
        }
        internal  void Attribute(int productid,string productname,double price,string color)
        {
           
            this.productId = 271099;
            this.productName = "pen drive";
            this.price = 2500;
            this.color = "black";


        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product1;
            product1 = new Product();
            
            product1.Attribute(271099,"pendrive",2500, "black");

            product1.Display();

        }
    }
}