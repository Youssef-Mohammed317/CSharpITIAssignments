using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Animal
    {
        public int Age { get; set; } = 0;

        public string Name { get; set; } = string.Empty;

        public bool IsAlive { get; set; } = true;
        public override string ToString()
        {
            return "I'm an Animal...";
        }
    }
}
