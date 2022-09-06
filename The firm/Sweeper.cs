using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm
{
    internal class Sweeper : Employee
    {
        //constructor
        public Sweeper(string firstName, string lastName, string cprNumber) : base (firstName, lastName, cprNumber)
        {

        }

        //method that link to the abstract method in the superclass named employee
        //and therefore the propertys firstname, lastname and cprnumber can be reached
        protected internal override void GetInfo()
        {
            Console.WriteLine("Sweeper");
            Console.WriteLine(this.FirstName);
            Console.WriteLine(this.LastName);
            Console.WriteLine(this.CprNumber);
            Console.WriteLine();
        }
    }
}
