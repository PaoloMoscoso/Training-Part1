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
        
        public void InitializePerson()
        {
            string input;
            Console.WriteLine("Please enter Person Name");
            input = Console.ReadLine();
            name = input;
            Console.WriteLine("Please enter Person Salary");
            input = Console.ReadLine();
            salary = int.Parse(input);
        }
        public void PrintPerson()
        {
            Console.WriteLine("the date of a Person is : ");
            Console.WriteLine("Name  :" + name);
            Console.WriteLine(name);
            Console.WriteLine("Salary :", salary);
            Console.WriteLine(salary);

        }

        public void PrintTax()
        {
            string tax = salary > 3000 ? "you have taxs" : "you dont have taxes";
            Console.WriteLine(tax);
        }


        static void Main(string[] args)
        {
            Person person = new Person();
            person.InitializePerson();
            person.PrintPerson();
            person.PrintTax();
            Console.ReadKey();
        }
    }
}
