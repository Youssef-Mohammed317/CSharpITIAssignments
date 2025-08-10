using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Bank
    {
        List<Account>? accounts;

        public string? Name { get; set; }

        public Bank(string name)
        {
            Name = name;
            accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            accounts?.Add(account);

            account.OnDepositTransaction += SendADepositMsg;

            account.OnWithdrawTransaction += SendAWithdrawMsg;

            if(account is CheckingAccount checkingAccount)
            {
                checkingAccount.OnOverdraftUsed += SendOverdraftLimitMsg;
            }
        }

        public void SendADepositMsg(Account account,float amount)
        {
            Console.WriteLine($"This account:{account.AccountNumber} has Deposit {amount},Your New Balance is {account.Balance}");
        }
        public void SendAWithdrawMsg(Account account,float amount)
        {
            Console.WriteLine($"This account:{account.AccountNumber} has Withdraw {amount},Your New Balance is {account.Balance}");
        }
        public void SendOverdraftLimitMsg(float OverdraftLimit, float amount)
        {
            Console.WriteLine($"The Overdraft Limit is {OverdraftLimit} and you want to draw a {amount},please enter a vaild amount");
        }


        //bool Filter(Account account)
        //{

        //}



        //public List<Account> FilterAccounts(IAccountFilter filter)
        //{

        //    return accounts?.Where(i => Filter(i));
        //}
    }
}
