using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace multipleinstances
{

    class Product
    {
        internal string productname;
        internal string color;
        internal double price;
        internal int productnumber;

        internal void Display()
        {
            Console.WriteLine("name: " + productname + " " + "color: " + color + "  " + "Rs: " + price + " " + "Number: " + productnumber);
        }
        internal Product()
        {
            Console.WriteLine("Empty Object Initialization");
        }
        internal Product(string productname, string color, double price, int productnumber)
        {
            Console.WriteLine("Object Initialized");
            this.productname = productname;
            this.color = color;
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
            P3.color = "black";
            P3.price = 2000;
            P3.productnumber = 15780;
            P3.Display();

            Product P4 = new Product("hp", " silver", 2200, 13480);
            P4.Display();
            Product P5 = new Product("kingston", "black", 2500, 15680);
            P5.Display();
            Console.ReadLine();
        }
    }
}