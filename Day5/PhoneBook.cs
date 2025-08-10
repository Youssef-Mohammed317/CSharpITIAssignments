using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class PhoneBook
    {
        public Dictionary<string, int>? phoneBook { get; set; }
        public int this[string key]
        {
            get
            {
                return phoneBook is not null? phoneBook[key] : -1;
            }
            set
            {
                if (phoneBook is not null)
                    phoneBook[key] = value;
            }
        }
        public string this[int val]
        {
            get
            {
                if(phoneBook is not null)
                foreach(var item in phoneBook)
                {
                    if(item.Value == val) return item.Key;
                }

                return "Not Found";
            }
            set
            {
                if(phoneBook is not null)
                foreach (var item in phoneBook)
                {
                    if (item.Value == val)
                    {
                        phoneBook[item.Key] = item.Value;
                        return;
                    }
                }
            }
        }
    }
}
