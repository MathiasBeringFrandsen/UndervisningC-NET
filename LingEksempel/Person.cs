using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingEksempel
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string MobileNumber { get; set; }

        public Person(int id, string name, int age, string mobileNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            MobileNumber = mobileNumber;
        }

        public Person() { }
    }
}
