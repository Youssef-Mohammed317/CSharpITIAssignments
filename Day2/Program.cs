namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day2

            #region Q1
            /*
             1.	Design an Employee struct that contains the following:
                -	Name,  Salary & Role
                -	Role may be (Admin, Accountant, Stock & Reception)
                -	Employee may have multiple roles
                -	Write a function void Display() that displays all employee data
                -	Write a function void AssignRole(Role role) that add a role to the employee.
                -	Write a function bool HasRole(Role role) that checks if the employee has that role.
             */
            //Employee emp = new Employee();
            //emp.Display(); // Name:,Salary:0,Role:None
            //emp.Name = "Test";
            //emp.Salary = 1000;
            //emp.AssignRole(EmpRole.Admin);
            //emp.Display(); // Name:Test,Salary:1000,Role:Admin
            //if (emp.HasRole(EmpRole.Reception)) Console.WriteLine("Has Role");
            //else Console.WriteLine("Don't Have Role");
            //emp.Display(); // Name:Test,Salary:1000,Role:Admin
            //emp.AssignRole(EmpRole.Stock);
            //if (emp.HasRole(EmpRole.Admin)) Console.WriteLine("Has Role");
            //else Console.WriteLine("Don't Have Role");
            //emp.Display(); // Name:Test,Salary:1000,Role:Admin, Stock
            //emp.AssignRole(EmpRole.Full);
            //emp.Display(); // Name:Test,Salary:1000,Role:Full
            //if (emp.HasRole(EmpRole.Reception)) Console.WriteLine("Has Role");
            //else Console.WriteLine("Don't Have Role");
            #endregion

            #region Q2
            /*
             2.	Design a 3D Point Class and Include the basic Constructor(s) [ use constructors  chaining & object Initializer] 
                -	Create two points P1, P2 with the same coordinates.
                -	Try to use == operator
                -	Write a function void Display()  to display point coordinates
                -	Write a function void ChangeCoordinates(int newX, int newY, int newZ)
             */
            //Point3D P1 = new Point3D()
            //{
            //    X = 1,
            //    Y = 2,
            //    Z = 3
            //};
            //Point3D P2 = new Point3D(1, 2, 3);
            //Console.WriteLine(P1 == P2);
            //P1.Display();
            //P1.ChangeCoordinates(10, 20, 30);
            //P1.Display();
            //Console.WriteLine(P1 == P2);
            //Console.WriteLine(P1 != P2);

            #endregion

            #region Q3
            /*
             3.	Write a function that takes a string as input and changes its value. Try to display the original 
                string after calling the function, Does it changes?
             */
            //string s = "I am Youssef";
            //ChangeString(s);
            //Console.WriteLine(s); // I am Youssef Not Change Because String is Imputable Data Type
            #endregion

            #endregion
        }
        #region Day2.Q3
        public static void ChangeString(string str)
        {
            str = "Hello, World!";
        }
        #endregion
    }
}
