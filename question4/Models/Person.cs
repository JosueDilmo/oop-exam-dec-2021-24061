using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Person(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

    }
}
