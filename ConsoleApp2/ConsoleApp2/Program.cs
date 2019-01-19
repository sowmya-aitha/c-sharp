using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string title= "WELCOME TO C SHARP";
            Console.WriteLine(title);
            
            Console.WriteLine("lower case : " + title.ToLower());
            string name;
            Console.Write("enter your name:");
            name = Console.ReadLine();
            Console.WriteLine(name.ToUpper());
            
            Book ob = new Book("somwya");
            Book sb = new Book("sharah");
            Book vb = new Book("srividya");
            Book sg= new Book("bhuvanaravulla");
            Class2 xb = new Class2();
            Console.ReadLine();
        }
    }
}
