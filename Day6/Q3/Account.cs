using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Account : IAccountFilter
    {
        public event Action<Account,float> OnDepositTransaction;
        public event Action<Account,float> OnWithdrawTransaction;
        public string? AccountNumber { get; set; }

        public float Balance { get; set; }

        public Account() { }
        public Account(string? accountNumber, float balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(float amount)
        {
            if(amount < 0) Console.WriteLine("Invalid amount");
            
            Balance += amount;

            OnDepositTransaction.Invoke(this,amount);
        }

        public virtual void Withdraw(float amount)
        {
            if(amount < 0) Console.WriteLine("Invalid amount");

            if(Balance < amount)
            {
                Console.WriteLine("There is not enough balance in your account");
                return;
            }

            Balance -= amount;

            OnWithdrawTransaction.Invoke(this,amount);
        }


        public bool Filter(Account account)
        {
            return account.Balance > 1000;
        }
    }
}
