using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm
{
    internal class ProjectManager : Manager
    {
        //property
        private string email;

        //encapsulation
        public string Email
        {
            get { return email; }
        }

        //constructor
        public ProjectManager(string firstName, string lastName, string cprNumber, string phoneNumber, string email) : base(firstName, lastName, cprNumber, phoneNumber)
        {
            this.email = email;
        }

        //method that link to the method in the manager class
        //that link to the abstract method in the superclass named employee
        //and therefore the property phonenumber from manager class,
        //and the firstname, lastname and cprnumber from the employee class can be reached
        protected internal override void GetInfo()
        {
            Console.WriteLine("Project manager:");
            Console.WriteLine(this.FirstName);
            Console.WriteLine(this.LastName);
            Console.WriteLine(this.CprNumber);
            Console.WriteLine(this.PhoneNumber);
            Console.WriteLine(email);
            Console.WriteLine();
        }
    }
}
