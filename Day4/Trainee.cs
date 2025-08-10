using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Trainee : Person,IPayable, IComparer<Trainee>
    {

        public int NID { get; set; }
        public int IntakeNumber { get; set; }

        public decimal Salary { get; set; }

        public int Compare(Trainee x, Trainee y)
        {
            int num = string.Compare(x.Name, y.Name);

            if (num == 0) return x.Salary.CompareTo(y.Salary);

            return num;
        }

        public void ShowPayment()
        {
            Console.WriteLine($"Salary:{Salary:C}");
        }

        public override string ToString()
        {
            return $"I'm Trainee\nName:{Name}, Age:{Age}, NID:{NID}, IntakeNumber:{IntakeNumber}, Salary:{Salary:C}";
        }
    }
}
