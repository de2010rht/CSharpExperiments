using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Diagnostics.Debug.WriteLine("I am learning C#.");

            Console.Write("Enter first name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // String concatenation
            Console.WriteLine("Hi " + name + ", you are " + age + " years old");

            // String interpolation
            Console.WriteLine($"Hi {name}, you are {age} years old");

            // String format
            double price = 170.36;
            string item = "iPhone XR";
            Console.WriteLine("Price of {0} is {1}", item, price);
            Console.WriteLine("Price of {0} is {1:C}", item, price);
            Console.WriteLine(String.Format("{0, 10} {1, 12}", "Item Name", "Item Price"));
            Console.WriteLine(String.Format("{0, 10} {1, 12}", item, price));

            // Escape sequence
            Console.WriteLine("C:\\Users\\Rohitaswa\\Downloads");
            Console.WriteLine(@"C:\Users\Rohitaswa\Downloads"); // @ ignores all escape sequence
        }
    }
}
