using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public string name;
        public DateTime birthDate;
        public enum Genders { male, female };

        public Person(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return "name: " + name + "\n" +
                   "date of birth: " + birthDate;
        }
    }

    class Employee : Person, ICloneable
    {
        public int salary;
        public string profession;

        public Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "salary: " + salary + "\n" +
                   "profession: " + profession;
        }
    }

    class Room : Employee
    {
        public int Number;

        public Room(int Number)
        {
            this.Number = Number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
