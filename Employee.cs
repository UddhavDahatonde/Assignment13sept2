using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13sept2
{
    public class Employee
    {
        string Name;
        int id;
        double salary;
        public void AssignValue()
        {
            Name = "Uddhav Dahatonde";
            id = 123;
            salary = 50000.0;
        }
        public string DisplayValue()
        {
            return $"Name==>{Name} id==>{id} salary ==>{salary}";
        }
    }
}
