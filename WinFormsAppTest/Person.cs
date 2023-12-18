using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppTest
{
    [Serializable]
    class Person
    {
        public Person() { }
        public Person(string? name, int age, string? sex, string? description)
        {
            Name = name;
            this.age = age;
            this.sex = sex;
            Description = description;
        }


        public string? Name { get; set; }
        public int age { get; set; }
        public string? sex { get; set; }
        public string? Description { get; set; }     

    }
}
