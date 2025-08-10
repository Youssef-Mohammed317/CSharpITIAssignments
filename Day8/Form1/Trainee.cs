using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Q1
{
    internal class Trainee
    {
        public string Name { get; set; } = string.Empty;

        private Lab lab;

        public string LabName
        {
            get { return lab.Name; }
        }

        public Trainee()
        {
            lab = new Lab();
        }
        public Trainee(string name)
        {
            Name = name;
            lab = new Lab();
        }
        public Trainee(string name,Lab lab)
        {
            Name = name;
            this.lab = lab;
        }
        public void setLab(object? lab)
        {
            if (lab is Lab l && lab is not null) this.lab = l;
        }
        public void removeLab()
        {
            this.lab = new Lab();
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
