//Write a program to find the largest of three numbers?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class LARGESTOFTHREE
    {

            public static void Main(string[] args)

            {

                int a, b, c;

                Console.WriteLine("enter three num");

                a = int.Parse(Console.ReadLine());

                b = int.Parse(Console.ReadLine());

                c = int.Parse(Console.ReadLine());

                if (a > b && a > c)

                {

                    Console.WriteLine(a + " is greater");

                }

                else if (b > c)

                {

                    Console.WriteLine(b + " is greater");

                }

                else





                {

                    Console.WriteLine(c + " is greater");

                }

                Console.ReadKey();

            }

    }

}

