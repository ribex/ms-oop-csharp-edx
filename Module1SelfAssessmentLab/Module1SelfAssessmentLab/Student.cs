namespace Module1SelfAssessmentLab
{
    public class Student
    {
        private string _name;
        private double _gpa;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public static int studentCount = 0;

        public Student(string _name)
        {
            this.Name = _name;
            studentCount++;
        }

        public Student(string _name, double gpa)
        {
            this.Name = _name;
            this.Gpa = gpa;
            studentCount++;
        }
    }
}