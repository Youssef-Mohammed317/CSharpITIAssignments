using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Employee
    {
        public string Name { get; set; } = "";

        public float Salary { get; set; }

        public event Action<float> OnSalaryIncreased;

        public Employee(string name, float salary)
        {
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(float amount)
        {
            Salary += amount;

            OnSalaryIncreased?.Invoke(amount);
        }

        public override string ToString()
        {
            return Name + ", " + Salary;
        }
    }
}
