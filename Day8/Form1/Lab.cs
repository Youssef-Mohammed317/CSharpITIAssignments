using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Q1
{
    internal class Lab
    {
        public string Name { get; set; } = string.Empty;

        public List<Trainee> Trainees { get; set; }

        public Lab()
        {
            Trainees = new List<Trainee>();
        }

        public Lab(string name)
        {
            Name = name;
            Trainees = new List<Trainee>();
        }
        public Lab(string name, List<Trainee> trainees)
        {
            Name = name;
            Trainees = trainees;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
