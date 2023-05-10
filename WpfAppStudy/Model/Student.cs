using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppStudy.Model
{
    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Student(int Id,string Name,string Description) { 
            this.Id = Id;
            this.Name = Name;
            this.Description = Description; 
        }


    }
}
