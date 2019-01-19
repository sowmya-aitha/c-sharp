using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Book
    {
        string Name; 

       public Book(string name)
        {
            Name = name;
            int Length;
            string rev;
            rev = "";
            Length = Name.Length-1;
            while (Length >= 0)
            {
                rev = rev + Name[Length];
                Length--;
            }
            Console.WriteLine(rev);
            Console.ReadLine();

        }
    }
}