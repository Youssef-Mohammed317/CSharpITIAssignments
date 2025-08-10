using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    //delegate List<Day6._0.Employee> delFilterEmployees();
    internal class Company
    {
        public string Name { get; set; } = "";
        public float Budget { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Company(string name, float budget)
        {
            Name = name;
            Budget = budget;
        }

        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
            emp.OnSalaryIncreased += DecreaseBudget;
        }

        public void DecreaseBudget(float amount)
        {
            Budget -= amount;
        }

        public List<Employee> FilterEmployees(Func<Employee,bool> filter)
        {
            return Employees.Where(filter).ToList();
        }

        public override string ToString()
        {
            return Name + ", " + Budget;
        }
    }
}
