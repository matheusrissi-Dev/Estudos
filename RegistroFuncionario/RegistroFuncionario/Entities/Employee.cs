using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroFuncionario.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int hours { get; set; }
        public double ValueperHour { get; set; }


        public Employee() { }

        public Employee(string name, int hours, double valueperHour)
        {
            Name = name;
            this.hours = hours;
            ValueperHour = valueperHour;
        }
        public virtual double Payment()
        {
            return ValueperHour * hours;
        }

    }
}
