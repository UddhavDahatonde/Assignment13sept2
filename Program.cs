using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13sept2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new Employee();
            employee.AssignValue();
            Console.WriteLine(employee.DisplayValue());
        }
    }
}
