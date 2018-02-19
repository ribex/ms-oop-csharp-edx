namespace Module2SelfAssessmentLab
{
    public class Student : Person
    {
        private double _gpa;

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public static int studentCount = 0;

        public Student(string name, int age, string cityOfResidence, double gpa) : base(name, age, cityOfResidence)
        {
            this.Gpa = gpa;
            studentCount++;
        }
    }
}