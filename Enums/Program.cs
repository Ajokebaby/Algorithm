using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of account ");
             string choice=Console.ReadLine(  );
           bool isvalid= Enum.TryParse<AccountType>( choice, out var value);  
            if( isvalid )
            {
                //bool isvalidInput = Enum.IsDefined(typeof(AccountType), value);
                //if (isvalidInput)
                //{
                    Console.WriteLine("valid account type");
                //}
                //else
                //{
                //    Console.WriteLine("invalid account type");
                //}
            }
            else
            {
                Console.WriteLine("invalid account type");
            }
            // int input= int.Parse(choice);
            string c = AccountType.SAVINGS.ToString();
        }


        /*
         Enums are strongly typed constants.The main use of enum is to ensure data consistency

        SAVINGS,CURRENT,FIXED_DEPOSIT
        -to validate enum when a user enters a enum as a string use  Enum.TryParse<AccountType>(choice, out var value)
        where choice is the string entered and value is the output

         -to validate enum when a user enters a enum as an integer use  Enum.IsDefined(typeof(AccountType), value)
        where  value is the input in integer 
         
         
         */
        public enum AccountType
        {
            SAVINGS=1,
            CURRENT,
            FIXED_DEPOSITS
        }

        public enum Status
        {
            PENDING = 1,
            REJECTED,
            APPROVED
        }
    }
}
