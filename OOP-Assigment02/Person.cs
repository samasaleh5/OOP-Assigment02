using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment02
{
    internal struct Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
