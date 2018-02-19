namespace Module2TutorialLab2
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