using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm
{
    internal abstract class Employee
    {
        //property's
        private string firstName;
        private string lastName;
        private string cprNumber;

        //encapsulations
        public string FirstName {get { return firstName;}}
        public string LastName {get { return lastName;}}
        public string CprNumber {get { return cprNumber;}}

        //constructor
        public Employee(string firstName, string lastName, string cprNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cprNumber = cprNumber;
        }

        //abstract method used though the inheriting classes from the sup Classes 
        protected internal abstract void GetInfo();

    }
}
