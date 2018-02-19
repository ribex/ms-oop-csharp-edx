using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2TutorialLab1
{
    class BusinessEmployee : Employee
    {
        public BusinessEmployee(string name) : base(name, 50000)
        {
            
        }

        public double bonusBudget = 1000;

        public override string employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
