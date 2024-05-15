using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroFuncionario.Entities
{
    internal class OutSourceEmployee : Employee
    {
        public double AdditionalChange { get; set; }


        public OutSourceEmployee() { }

        public OutSourceEmployee(string name, int hours, double valueperHour, double additionalChange) : base(name, hours, valueperHour)
        {
            AdditionalChange = additionalChange;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalChange;
        }
    }
}
