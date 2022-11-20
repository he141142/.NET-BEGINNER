using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.entity
{
    class Teacher
    {
        private string email;
        private string shortName;
        private string fullName;
        private int age;
        private DateTime dob;

        public Teacher() { }

        public string Email { get => email; set => email = value; }
        public string ShortName { get => shortName; set => shortName = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public int Age { get => age; set => age = value; }
        public DateTime Dob { get => dob; set => dob = value; }
    }
}
