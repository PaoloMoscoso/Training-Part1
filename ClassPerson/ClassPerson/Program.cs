using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    class Person
    {
        private string name;
        private int salary;
        
        public void initializePerson()
        {
            string input;
            Console.WriteLine("Please enter Person Name");
            input = Console.ReadLine();
            name = input;
            Console.WriteLine("Please enter Person Salary");
            input = Console.ReadLine();
            salary = int.Parse(input);
        }
        public void printPerson()
        {
            Console.WriteLine("the date of a Person is : ");
            Console.WriteLine("Name :", name);
            Console.WriteLine("Salary :", salary);
        }

        static void Main(string[] args)
        {
        }
    }
}
