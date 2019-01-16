using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            string name = "sowmya aitha";
            int age = 21;
            char grade = 'A';
            Console.WriteLine(name.Substring(8, 3));
            Console.WriteLine("name is " + name + " age is " + age + " grade is " + grade);
            Console.WriteLine(" length  of name is: " + name.Length + '\n' + " upper " + name.ToUpper());
            string[] names = new string[3];
            names[0] = "xxx";
            names[1] = "yyyy";
            names[2] = "zzzzz";
            Console.WriteLine(names[0] + '\n' + names[1] + '\n' + names[2]);
            Console.WriteLine(" --- ");
            Console.WriteLine("    / ");
            Console.WriteLine("  /");
            Console.Write("Enter a value");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter b value");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(Math.Pow(a, b));
            Console.ReadLine();
            

        }
    }
}
