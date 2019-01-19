using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class2
    {
        
        public Class2( )
        {
            int num,i,count ;
            for (  num = 1; num <= 100; num++)
            {
                count = 0;
                for (i = 2; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && num != 1)
                {
                    Console.WriteLine(num);
                }
            }

                }
    }
}
