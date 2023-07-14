using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppStudy.Model
{
    class Student:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler propertyChanged;
        public int Id { set
            {
                Id = value;
                if (this.PropertyChanged != null)
                {

                }
            }
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public Student(int Id,string Name,string Description) { 
            this.Id = Id;
            this.Name = Name;
            this.Description = Description; 
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
