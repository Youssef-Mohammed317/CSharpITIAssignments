namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day4
            // Note: use classes designed in Day 3
            #region Q:A
            /*
             A.	Regarding class Point
                1.	In your main program, create an array of Point class
                2.	Modify Point class to implement IComparable
                3.	Sort you array of Points
                4.	Implement IClonable interface
             */
            //Point[] points = new Point[3]
            //{
            //    new Point(){X = 1},
            //    new Point(){X = 2},
            //    new Point(){X = 3},
            //};

            //foreach (Point p in points)
            //{
            //    Console.WriteLine(p.ToString());
            //}
            //object point = points[1].Clone();
            //Point? pp = point as Point;
            //Console.WriteLine($"new point:{point} Hash{point.GetHashCode()}");
            //Console.WriteLine($"new point:{pp} Hash{pp?.GetHashCode()}");
            //Console.WriteLine($"old point:{points[0]} Hash{points[0].GetHashCode()}");
            #endregion

            #region Q:B
            /*
             B.	Regarding class Employee & Trainee
                1.	Design an interface IPayable that contains:
                    -	Salary Property
                    -	ShowPayment() that display the salary
                2.	Make Employee & Trainee implement IPayable
                    Try to implement IComparer interface to class Trainee
             */

            //Trainee trainee = new Trainee() { Salary = 1000 };
            //Employee emp = new Employee() { Salary = 2000 };

            //emp.ShowPayment();
            //trainee.ShowPayment();

            //List<Trainee> trainArr = new List<Trainee>
            //{
            //    new Trainee() { Name = "Ziad", Salary = 2000},
            //    new Trainee() { Name = "Ali", Salary = 1000},
            //    new Trainee() { Name = "Ali", Salary = 2000},
            //    new Trainee() { Name = "Youssef", Salary = 1500}
            //};

            //trainArr.Sort(new Trainee());

            //foreach (var train in trainArr)
            //{
            //    Console.WriteLine(train);
            //}

            #endregion

            #region Q:C
            /*
             A.	Design a new class PhoneBook, such that the following code is valid:
                PhoneBook phoneBook = new PhoneBook();
                phonebook[123] = “Ali”;
                phonebook[“Hosam”] = 456;
                int phone = phonebook[“Ali”]
             */

            //PhoneBook phoneBook = new PhoneBook();
            //phoneBook[123] = "Ali";
            //phoneBook["Hosam"] = 456;
            //int phone = phoneBook["Ali"];

            #endregion

            #endregion
        }
    }
}
