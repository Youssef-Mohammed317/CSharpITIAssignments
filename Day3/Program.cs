using System;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day3

            #region Q1
            /*          
            1. Use your 3D Point class from previous day: 
                -	Override ToString() & Equals() functions 
                -	Create two points P1, P2 with the same coordinates.
                -	Try to use == operator & Equals()
                -	Write a function void Display(Point3D[] arr)  that iterate over array of points to display them.
             */
            //Point3D P1 = new Point3D(1, 1, 1);
            //Point3D P2 = new Point3D(1, 1, 1);
            //if (P1 == P2) Console.WriteLine("The Same");
            //else Console.WriteLine("Not The Same");
            //if (P1.Equals(P2)) Console.WriteLine("Equals");
            //else Console.WriteLine("Not Equals");
            //Point3D[] arr = { P1, P2 };
            //Point3D.Display(arr);
            #endregion

            #region Q2
            /*
             2. Design a Person class (Each person has a name & age)
                -	Design two classes Employee & Trainee both inherit from Person 
                    (Employee has a NID & Salary – Trainee has NID & IntakeNumber)
                -	Override ToString() in all previous classes
                    In your Program class:
                -	Create an array holding a collection of Person, Employee & Trainee, then try to display array data.
                -	Create a function string GetType(Person p) that return a string representing the type of the Person object 
                    (Object type not reference type)
             */

            //Person[] people = new Person[3]
            //{
            //    new Person()
            //    {
            //        Name= "Person Name",
            //        Age = 28
            //    },
            //    new Trainee()
            //    {
            //        Name = "Person Name",
            //        Age = 28,
            //        IntakeNumber = 10,
            //        NID = 2000
            //    },
            //    new Day3.Employee()
            //    {
            //        Name = "Person Name",
            //        Age = 28,
            //        Salary = 10000,
            //        NID = 1010
            //    },
            //};

            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person.ToString());
            //    Console.WriteLine(GetType(person));
            //    Console.WriteLine("**************");
            //}
            #endregion

            #endregion
        }
        #region Day3.Q2
        static public string GetType(Person person)
        {
            if (person is Employee) return "Employee Object";
            if (person is Trainee) return "Trainee Object";
            if (person is Person) return "Person Object";
            return "Object";
        }
        #endregion
    }
}
