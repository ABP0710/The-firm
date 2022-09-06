using System;

namespace The_firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a assignment for school

            //creates new objects from det different classes
            Employee m1 = new Manager("Han", "Solo", "010172-6597", "45786932");
            Employee p1 = new ProjectManager("Emperor", "Plapatine", "111111-8844", "666fff666", "hell@nd.back");
            Employee s1 = new Sweeper("Jarjar", "Bings", "280704-9291");

            //calls the methods from the diffrent classes
            m1.GetInfo();
            p1.GetInfo();
            s1.GetInfo();
        }
    }
}
