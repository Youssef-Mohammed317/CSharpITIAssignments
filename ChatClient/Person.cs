using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    internal class Person
    {
        public string Username { get; set; } = string.Empty;
        public Person(string username)
        {
            Username = username;
        }
    }
}
