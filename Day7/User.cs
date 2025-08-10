using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    [Flags]
    enum GenderEnum
    {
        None = 0,Male = 1, Female = 2,
    }
    enum HoppiesEnum
    { 
        None = 0,
        Football = 1,
        Tennis = 2,
        Swimming = 4,
    }

    internal class User
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";

        public GenderEnum Gender { get; set; }

        public HoppiesEnum Hoppies { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}, Email:{Email}, Gender:{Gender}, Hoppies:{Hoppies}";
        }
    }
}
