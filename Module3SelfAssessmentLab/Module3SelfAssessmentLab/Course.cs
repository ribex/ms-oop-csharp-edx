using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3SelfAssessmentLab
{
    public class Course
    {
        private Student[] _students;
        private Teacher[] _teachers;
        private string _name;

        public string Name

        {
            get { return _name; }
            set { _name = value; }
        }

        public Student[] Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public Teacher[] Teachers
        {
            get { return _teachers; }
            set { _teachers = value; }
        }

        public Course(Student[] students, Teacher[] teachers)
        {
            _students = students;
            _teachers = teachers;
        }

        public Course(string name)
        {
            this.Name = name;
        }
    }
}
