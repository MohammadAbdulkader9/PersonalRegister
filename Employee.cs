using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    class Employee
    {
        public string name;
        public double salary;
        public int ID;

        public Employee(int ID, string name, double salary)
        {
            this.ID = ID;
            this.name = name;
            this.salary = salary;
        }
    }
}
