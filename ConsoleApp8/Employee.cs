using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class EmployeeComparerSalary : IComparer
    {
        public int Compare(object x, object y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y; 
            if (X.Salary > Y.Salary) return 555;
            else if (X.Salary < Y.Salary) return -555;
            else return 0;

        }
    }



    internal class Employee : IComparable //ICloneable 
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }
        public object Clone()
        { 
            return new Employee(this);
            //return new Employee() { Id = this.Id, Name = this.Name, Age = this.Age, Salary = this.Salary };
        }
        // Copy constructore
        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
            Age = employee.Age;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Age}, {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee e = (Employee)obj;
            //if (this.Age > e.Age) return 5;
            //else if (this.Age < e.Age) return -5;
            //else return 0;
            // == 
            return this.Age.CompareTo(e.Age);
        }
    }
}
