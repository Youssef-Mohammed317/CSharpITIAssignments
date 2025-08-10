using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    [Flags]
    enum EmpRole
    {
        None = 0,
        Admin = 1,
        Accountant = 2,
        Stock = 4,
        Reception = 8,
        Full = Admin + Accountant + Stock + Reception,

    }
    internal struct Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public EmpRole Role { get; set; }

        public void Display()
        {
            Console.WriteLine($"Name:{Name},Salary:{Salary},Role:{Role}");
        }

        public void AssignRole(EmpRole role)
        {
            Role = role | Role;
        }
        public bool HasRole(EmpRole role)
        {
            EmpRole temp = Role & role;
            return temp == role;
        }
    }
}
