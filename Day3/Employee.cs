using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Employee : Person
    {
        public int NID { get; set; }
        public decimal Salary { get; set; }

        public void ShowPayment()
        {
            Console.WriteLine($"Salary:{Salary:C}");
        }

        public override string ToString()
        {
            return $"I'm Employee\nName:{Name}, Age:{Age}, NID:{NID}, Salary:{Salary:C}";
        }
    }
}
