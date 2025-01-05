using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using ConsoleApp8.Interface;
using ConsoleApp8.Interface02;
using ConsoleApp8.Interface03;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp8
{
    internal class Program
    {
        //static void Print10Num(SeriesByTwo series)
        //{
        //    for(int i=0; i<10; i++)
        //    {
        //        Console.Write(series.Current);
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}
        //static void Print10Num(SeriesBtThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write(series.Current);
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}
        static void Print10Num(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(series.Current);
                series.Next();
            }
            Console.WriteLine();
            series.Reset();
        }
        static void Main(string[] args)
        {
            #region Interface
            // reference data type 
            // Code Contruct: Between The developer who write it and the developer who use

            //IMyType myType = new IMyType(); // invalid
            // can't create object from any Interface
            // can create reference from Interface and it can refere 
            //IMyType mytype;
            //MyType myType = new MyType();
            //myType.Myfun();
            //myType.Salary = 12;
            //Console.WriteLine(myType.Salary);
            //mytype.Print();

            #endregion

            #region Ex02
            //SeriesByTwo series = new SeriesByTwo();
            //SeriesBtThree series3 = new SeriesBtThree();
            //Print10Num(series3);
            #endregion

            #region Ex03
            // Multiple inheritance not supported
            //Car car = new Car();
            //car.Speed = 120;
            //car.Forward();
            //AirPlane airPlane = new AirPlane();
            //// refrence access not object 
            //IMovable movable = airPlane;
            //movable.Backward();
            //IFlyable flyable = airPlane;
            //flyable.Backward();

            #endregion

            #region Shallow copy Vs Deep Copy
            //int[] arr01 = [1, 2, 3];
            //int[] arr02 = [4, 5, 6];
            //Console.WriteLine($"{arr01.GetHashCode()}");
            //Console.WriteLine($"{arr02.GetHashCode()}");
            // 1. shallow copy
            //arr02 = arr01; // shallow copy : copy of identity
            //// [1, 2, 3];2 refrenceses 
            //// [4, 5, 6]; unreachable object
            //Console.WriteLine();
            ////any obj from ref type => Identity , object state(data)
            //Console.WriteLine($"{arr01.GetHashCode()}");
            //Console.WriteLine($"{arr02.GetHashCode()}");

            // 2. Deep copy : copy from object state
            //arr02 = (int[])arr01.Clone();
            //// clone methode will copy object state of the caller
            //// assign new obj to arr02, will generate new identity
            ////// [4, 5, 6]; unreachable object
            //Console.WriteLine();
            //Console.WriteLine($"{arr01.GetHashCode()}");
            //Console.WriteLine($"{arr02.GetHashCode()}");
            //arr02[0] = 100;
            //Console.WriteLine(arr02[0]); // 100
            //Console.WriteLine(arr01[0]); // 1
            // arr01 will not affected

            #endregion

            #region Build In Cloneable
            //Employee E01 = new Employee()
            //{
            //    Id = 1,
            //    Name = "mariam",
            //    Age = 25,
            //    Salary = 1200

            //};

            //Employee E02 = new Employee()
            //{
            //    Id = 2,
            //    Name = "omar",
            //    Age = 25,
            //    Salary = 1200

            //};
            ////E02 = E01; // shallow copy : same hashcode and data
            //// Deep copy 
            ////E02 = (Employee)E01.Clone();
            //E02 = new Employee(E01); //copy enstructor
            //// copy of object state of caller (E01)
            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());
            //Console.WriteLine(E01);
            //Console.WriteLine(E02);
            // same data , different hash code 

            #endregion
            #region Build in Compareable
            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){Id = 1, Name = "Mariam" , Age = 25, Salary= 15000 },
            //    new Employee(){Id = 2, Name ="omar" , Age = 20, Salary= 15000 },
            //    new Employee(){Id = 5, Name ="omar" , Age = 30, Salary= 15000 },

            //};
            ////Array.Sort(employees);
            //int X = employees[0].CompareTo(employees[2]);
            //// +ve value => caller greater than parameter
            //// -ve ==> caller less than parameter
            //// 0 ==> equal 

            ////foreach (Employee item in employees)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Console.WriteLine(X);
            #endregion
            Employee[] employees = new Employee[3]
            {
                new Employee(){Id = 1, Name = "Mariam" , Age = 25, Salary= 15000 },
                new Employee(){Id = 2, Name ="omar" , Age = 20, Salary= 18000 },
                new Employee(){Id = 5, Name ="omar" , Age = 30, Salary= 2000 },

            };
            Array.Sort(employees, new EmployeeComparerSalary());

            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
