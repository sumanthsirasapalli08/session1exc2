using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        internal string productname;
        internal string colour;
        internal double price;
        internal int productnumber;

        internal void Display()
        {
            Console.WriteLine("Name:" + productname + " " + "colour: " + " " + "Rs :" + price + " " + "Number:"+ productnumber);
        }
        internal Product()
        {
            Console.WriteLine("Empty Object Initialization");
        }
        internal Product(string productname, string colour, double price,int productnumber)
        {
            Console.WriteLine("Object Initialized");
            this.productname = productname;
            this.colour = colour;
            this.price = price;
            this.productnumber = productnumber;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product P3;
            P3 = new Product();
            P3.productname = "sandisk";
            P3.colour = "Black";
            P3.price = 1500;
            P3.productnumber = 7800;


            P3.Display();
            Product P4 = new Product("hp","silver", 4500,8700);
            P4.Display();
            Console.ReadLine();
        }
    }
}