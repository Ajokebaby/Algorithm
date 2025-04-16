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
            //3 multiplication table
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
               
                    Console.WriteLine($"multiplication table {N}: {N}*{i} {N * i} ");

            }

            //4
            //Console.WriteLine("write the range:");
            //int range = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= range; i += 2)
            //{
            //    if (range % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        continue;
            //    }

            //}
            //5 square
            //for (int i = 1; i <= 10; i++) 
            //{
                
            //    Console.WriteLine($"{i} squared is {i * i}");
            //}
            //
           
        }
       
    }
}
