using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class SavingsAccount : Account
    {
        public float InterestRate { get; set; }

        public SavingsAccount(float interestRate)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            Balance += InterestRate * Balance;
        }
    }
}
