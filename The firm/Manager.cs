using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm
{
    internal class Manager : Employee
    {
        //property
        private string phoneNumber;

        //encapsulation
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        //constructor
        public Manager(string firstName, string lastName, string cprNumber, string phoneNumber) : base(firstName, lastName, cprNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        //method that link to the abstract method in the superclass named employee
        //and therefore the propertys firstname, lastname and cprnumber can be reached
        protected internal override void GetInfo()
        {
            Console.WriteLine("Manager:");
            Console.WriteLine(this.FirstName);
            Console.WriteLine(this.LastName);
            Console.WriteLine(this.CprNumber);
            Console.WriteLine(phoneNumber);
            Console.WriteLine();
        }
    }
}
