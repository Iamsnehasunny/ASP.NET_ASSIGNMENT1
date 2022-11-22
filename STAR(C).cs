/*Print pattern
1
1 2
1 2 3 
1 2 3 4 
1 2 3 4 5 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class STAR_C_
    {

        static void Main(string[] args)
        {
            int  n;
            Console.Write("Enter the number of rows:\t");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j.ToString());
                Console.WriteLine();
            }

            Console.WriteLine();
        }

    }
}
