namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day1

            #region Q1
            /*
                1.Write a program that represents a simple calculator that has the following Operations:
                -	Add, Subtract, Multiply, Divide
                User should enter the two operands and the type of operation he wants.
            */
            //double num1 = 0,num2 = 0;
            //string op = "+";
            //do
            //{
            //    Console.Write("Enter First Number:");
            //    if (double.TryParse(Console.ReadLine(),out num1))
            //    {
            //        break;
            //    }
            //} while (true);
            //do
            //{
            //    Console.Write("Enter Second Number:");
            //    if (double.TryParse(Console.ReadLine(),out num2))
            //    {
            //        break;
            //    }
            //} while (true);
            //bool valid = false;
            //do
            //{
            //    Console.Write("Enter The Operator Number:");
            //    op = Console.ReadLine() ?? "+";
            //    switch (op)
            //    {
            //        case "+":
            //        case "-":
            //        case "*":
            //        case "/":
            //        case "%":
            //            valid = true;
            //            break;
            //    }
            //} while (!valid);

            //switch (op)
            //{
            //    case "+":
            //        Console.WriteLine($"{num1} + {num2} = {num1 + num2}"); break;
            //    case "-":
            //        Console.WriteLine($"{num1} - {num2} = {num1 - num2}"); break;
            //    case "*":
            //        Console.WriteLine($"{num1} * {num2} = {num1 * num2}"); break;
            //    case "/":
            //        Console.WriteLine($"{num1} / {num2} = {num1 / num2}"); break;
            //    case "%":
            //        Console.WriteLine($"{num1} % {num2} = {num1 % num2}"); break;

            //};

            #endregion

            #region Q2
            /*
                2.	Write a program to show the complete numbers in range [1, 1000].
                Note: A complete number is the one which sum of its factors equals the same number (e.g. 6 = 1 + 2 + 3)
             */
            //List<int> CompNumbers = new List<int>();
            //for (int i = 1; i <= 1000; i++)
            //{
            //    // get factors
            //    List<int> factors = new List<int>();
            //    for (int j = 1; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            factors.Add(j);
            //        }
            //    }
            //    int sum = 0;
            //    foreach(int j in factors)
            //    {
            //        sum += j;
            //    }
            //    if(sum == i)
            //    {
            //        CompNumbers.Add(i);
            //    }
            //}
            //Console.WriteLine(string.Join(", ",CompNumbers.ToArray()));

            #endregion

            #endregion
        }
    }
}
