/*
Write a program in C# Sharp to display the multiplication table of a given
integer "6"
1*6=6
2*6=12
….
10*6=60
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class MULTIPLICATIONTBL6
    {
        public static void Main(string[] args)
        {
            int mul = 1;
            for(int i=1; i <=10; i++)
            {
                mul =6*i;
                Console.WriteLine(+i + " *  6  ="  + mul);

            }
            
        }
    }
}
