using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.entity
{
    class Student
    {
        private int age;
        private string name;
        private string className;
        private string studentCode;
        private DateTime dob;
        

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string ClassName { get => className; set => className = value; }

        public Student buildName(string name) {
            this.name = name;
            return this;
        }


    }
}
