namespace Module2SelfAssessmentLab
{
    public abstract class Person
    {
        private string _name;
        private int _age;
        private string _cityOfResidence;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string CityOfResidence
        {
            get { return _cityOfResidence; }
            set { _cityOfResidence = value; }
        }

        public Person(string name, int age, string cityOfResidence)
        {
            this.Name = name;
            this.Age = age;
            this.CityOfResidence = cityOfResidence;
        }
    }
}