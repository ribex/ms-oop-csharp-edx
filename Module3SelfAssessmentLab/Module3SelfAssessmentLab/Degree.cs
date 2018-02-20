using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3SelfAssessmentLab
{
    public class Degree
    {
        private Course _course;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Course Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public Degree(string name)
        {
            this.Name = name;
        }

        public Degree(string name, Course course)
        {
            this.Name = name;
            this.Course = course;
        }
    }
}
