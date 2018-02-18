using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1SelfAssessmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public static int studentCount = 0;

        public Student()
        {
            studentCount++;
        }

        public Student(string name)
        {
            Name = name;
            studentCount++;
        }
    }

    public class Teacher
    {
        public string Name { get; set; }
        public static int teacherCount = 0;

        public Teacher()
        {
            teacherCount++;
        }

        public Teacher(string name)
        {
            Name = name;
            teacherCount++;
        }
    }

    public class UProgram
    {
    }

    public class Degree
    {
    }


    public class Course
    {
    }
}
