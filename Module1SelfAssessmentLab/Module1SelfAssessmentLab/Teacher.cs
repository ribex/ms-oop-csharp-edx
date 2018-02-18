namespace Module1SelfAssessmentLab
{
    public class Teacher
    {
        private string _name;
        private bool _tenured;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Tenured
        {
            get { return _tenured; }
            set { _tenured = value; }
        }

        public static int teacherCount = 0;

        public Teacher(string name)
        {
            this.Name = name;
            teacherCount++;
        }

        public Teacher(string name, bool tenured)
        {
            this.Name = name;
            this.Tenured = tenured;
            teacherCount++;
        }
    }
}