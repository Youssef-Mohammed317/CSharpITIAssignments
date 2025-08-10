using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class PhoneBook
    {
        public string[]? Name { get; set; }
        public int[]? Number { get; set; }
        public string this[int index]
        {
            get { return Name[index]; }
            set { Name[index] = value; }
        }
        public int this[string val]
        {
            get 
            {
                for (int i = 0; i < Name?.Length; i++)
                {
                    if (Name[i] == val)
                    {
                        return Number[i];
                    }
                }
                return -1;
            }
            set 
            {
                for (int i = 0; i < Name?.Length; i++)
                {
                    if (Name[i] == val)
                    {
                        Number[i] = value;
                    }
                }
            }
        }
    }
}
