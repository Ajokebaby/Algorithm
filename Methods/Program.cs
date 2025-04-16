using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            //Program isAdult = new Program();
            
           bool vote = Program.OfAge(age);
            if (vote== true)
            {
                Console.WriteLine($"She can vote");
            }
            else { Console.WriteLine($"She can not vote "); }
           
        }
        public static bool OfAge(int age)
        {   
            if (age >= 18) 
            {
                return true;
            } else
            { return false; }   
                
        }
    }
}
