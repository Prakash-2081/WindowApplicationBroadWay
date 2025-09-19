using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Desktop
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee(string _Name,int _Age)
        {
            Name = _Name;
            Age = _Age;
        }
    }
        public class PracticeBaseClass:Employee
    {
        public string CompanyName { get; set; }
        public PracticeBaseClass(string Name,int Age,string _CompanyName):base(Name,Age)
        {
            CompanyName = _CompanyName;
        }
        public void Method() {
            Console.WriteLine($"{CompanyName}");
        }
    }
}
