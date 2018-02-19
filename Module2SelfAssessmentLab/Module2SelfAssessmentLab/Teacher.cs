namespace Module2SelfAssessmentLab
{
    public class Teacher : Person
    {
        private bool _tenured;

        public bool Tenured
        {
            get { return _tenured; }
            set { _tenured = value; }
        }

        public static int teacherCount = 0;

        public Teacher(string name, int age, string cityOfResidence, bool tenured) : base(name, age, cityOfResidence)
        {
            this.Tenured = tenured;
            teacherCount++;
        }
    }
}