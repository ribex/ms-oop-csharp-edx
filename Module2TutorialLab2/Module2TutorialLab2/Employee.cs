namespace Module2TutorialLab2
{
    abstract class Employee
    {
        private static int employeeCount = 1;

        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }

        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }

        public int Id
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;

            }
        }


        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.Id = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        public string getName()
        {
            return this.Name;
        }

        public int getEmployeeId()
        {
            return this.Id;
        }

        public string toString()
        {
            return this.Id + " " + this.Name;
        }

        public abstract string employeeStatus();
    }
}