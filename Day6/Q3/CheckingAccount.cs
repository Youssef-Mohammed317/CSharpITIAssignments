using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class CheckingAccount : Account
    {
        public event Action<float,float> OnOverdraftUsed;
        public float OverdraftLimit { get; set; }

        public CheckingAccount(string? accountNumber,float balance,float overdraftLimit) : base(accountNumber,balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(float amount)
        {
            if(amount <= OverdraftLimit)
            {
                base.Withdraw(amount);
            }

            OnOverdraftUsed.Invoke(OverdraftLimit,amount);
        }

    }
}
