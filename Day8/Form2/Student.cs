using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Q2
{
    internal class Student
    {
        public string Name { get; set; } = string.Empty;
        public long Phone { get; set; } // unique
        public DateTime Birthdate { get; set; }

        public bool IsItACopy(Student student)
        {
            return this.Phone == student.Phone;
        }

        public Student(string name,long phone,DateTime dateTime)
        {
            Name = name;
            Phone = phone;
            Birthdate = dateTime;
        }
    }
}
