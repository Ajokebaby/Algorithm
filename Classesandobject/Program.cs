using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classesandobject
{
    class Program
    {
        static void Main(string[] args)
        {
            var new2 = new User("qaweey","soetan",13);
            
            var newUser = new User { 
            
            Age=12,

            FirstName="Qaweey",
            LastName="Soetan",
            Details=new AccountDetails
            {
                AccountBalance = 2000,
                AccountName = "Qaweey Soetan ",
                AccountNumber = "3456789032",
                AccountType = "SAVING"

            }
            

           
            
            };
            //var actDetails = new AccountDetails
            //{
            //    AccountBalance = 2000,
            //    AccountName = $"{newUser.FirstName} {newUser.LastName}",
            //    AccountNumber = "3456789032",
            //    AccountType = "SAVING"
            //};
            //newUser.Details=actDetails;
            User.Messages = "ssddddddd";
            Console.WriteLine(  $" my  details are :{newUser.FirstName}" +
                $"{newUser.Details.AccountNumber}" +
                $"" +
                $"" +
                $"");

            var Customer = new CustomerDetails
            {
                Id = 1,
                Email = "Soetan@gmail.com",
                FirstName = "Qawi",
                LastName = "Soetan",
                Password = "qaweey123",
                Photo = "eeyryryryrryhr/rytuyuueu"
            };
          CustomerDetailsDto user=  ReturnDetails(Customer);
            //var custDto = new CustomerDetailsDto
            //{
            //    FirstName = Customer.FirstName,
            //    Photo = Customer.Photo,
            //};
            Console.WriteLine(  $"User first name: {user.FirstName}, photo is {user.Photo}");
           
        }

        public static CustomerDetailsDto ReturnDetails(CustomerDetails customer)
        {
            var dto = new CustomerDetailsDto
            {
                FirstName = customer.FirstName,
                Photo = customer.Photo,
            };

            return dto; 

        }
    }
    /*
     Class: a class is a blue print of an object
    - A class is a  data type just like (string, int etc)
    -A class is a custom datatype.
    -C# have some inbuilt class e.g Program,string 
     
    Static entities - are entities that are accessed without instantiating e.g Classs, methods, properties

    -Uses Of Class
    1. Class as a model- A model interact with the database
    2. Data transfer objects(DTO) -Interact with the client 
    Constructor: is used to initialize properties in a class and used as a tool to facilitate dependency injection.All classes have a default constructor
    Declaring a constructor:To declare a constructor use the short cut 'ctor' and 'tab'
    There are two type of constructor 
    1.parameterless constructor: constructors without parameter
    2.parameterized constructor: constructors with parameter

     */
   public class User
    {
        public User(string firstName, string lastname,int age)
        {
            FirstName = firstName;
            Age = age;
            LastName=lastname;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static string Messages { get; set; }
        public int Age { get; set; }
        public bool isEligible()
        {
            //    if (Age >= 18)
            //    {
            //        return true;    
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //bool c = Age >= 18;
            //return c;

            bool c = Age >= 18 ? true : false; 
            return c ;
        }
        public AccountDetails Details { get; set; } 
        public string GetFullName()
        {
            string fullName = $"{FirstName} {LastName}";
            return fullName ;
        }

        public static string GetFirstName(string firstname)
        {

            return firstname;
        }

    }

    public class AccountDetails
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }



    }
    //Model
   public class CustomerDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string  Password { get; set; }

    }
    //Data Transfer Object
   public  class CustomerDetailsDto
    {
        public string FirstName { get; set; }
        public string Photo { get; set; }

    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public decimal Amount { get; set; }

    }

    public static class Cars
    {
        public static  string Name { get; set; }
        public static string Colour { get; set; }
        public static  string Brand { get; set; }
        public static string GetCarName()
        {
            return Name;
        }

    }

    //protected class Medicine
    //{
    //   public string Name { get; set; } 
    //}
}

