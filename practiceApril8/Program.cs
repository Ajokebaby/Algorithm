using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceApril8
{
    class Program
    {
        static void Main(string[] args)
        {
             
            List<int> list = new List<int>();
           
                Console.WriteLine("How many number do you want to add:");
            int lengthOfNumbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lengthOfNumbers; i++)
            {
                Console.WriteLine("Enter your number:");
                int num = int.Parse(Console.ReadLine());
                AddNumberToTheList(list, num);


            }
         int sumOfNumbers=  GetSumOfNumberInAList(list);
            Console.WriteLine($"The sum of the number is {sumOfNumbers}");
            Console.ReadLine();




            //i want to create a list
            //i want to populate the list with numbers
            //i want to sum up the number
        }
        //Methods: methods are functions that are used to run processes
        //Methods are divided into 3 components
        /*
         1. Access modifier
         2. Return type (of any type) optional
        3. Method name
         4. The parameters or arguments(of any type)  optional: the things you will need in a method
         Note We have two types of method 
        1. methods that returns value 2. methods that does not return value
        Advantages of Methods
        1. Method reduce code duplications.
        2. It improves code quality and code decoupling .
        Static Methods : They are methods that can be used anywhere without instantiating it.
         Method Overloading: method with the same name but different parameter
        -methods can return class and can take class as a parameter

         */
        //returnable methods

        public string GetFullName()
        {
            string fullname = "Qaweey Abidemi Soetan";
            return fullname;

        }
        
        public static  int  GetSumOfNumberInAList(List<int> listofNumbers)
        {
            int sumOfNumbers=listofNumbers.Sum(); 
            return sumOfNumbers;
        }

        public static int GetSumOfNumberInAList(List<int> listofNumbers, string name)
        {
            int sumOfNumbers = listofNumbers.Sum();
            return sumOfNumbers;
        }
        public static void AddNumberToTheList(List<int> list,int userInput)
        {
            list.Add(userInput);

        }
    }
    public class ease 
    {
        public int MyProperty { get; set; }
    }
    
   
}
