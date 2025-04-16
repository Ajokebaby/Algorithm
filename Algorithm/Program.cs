using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 sum
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum += i; 
            }

            Console.WriteLine($"The sum of the first {num} natural numbers is: {sum}");

            //3 multiplication table
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
               
                    Console.WriteLine($"multiplication table {n}: {n}*{i} {n * i} ");

            }

            //4
            Console.WriteLine("write the range:");
            int range = int.Parse(Console.ReadLine());

            for (int i = 0; i <= range; i += 2)
            {
                if (range % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }

            }
            //5 square
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine($"{i} squared is {i * i}");
            }
            //

        }

    }
}
