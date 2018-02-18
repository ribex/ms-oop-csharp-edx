using System;
using System.Collections;
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
            var universityProgram = new UProgram("Information Technology");
            var degree = new Degree("Bachelor");
            universityProgram.Degree = degree;

            var course = new Course("Programming with C#");
            degree.Course = course;

            Student student1 = new Student("Bob Smiley", 3.4);
            Student student2 = new Student("Mary Madsen", 3.7);
            Student student3 = new Student("Liza Abrahms", 4.0);

            var sArray = new Student[3];
            sArray[0] = student1;
            sArray[1] = student2;
            sArray[2] = student3;

            course.Students = sArray;

            Teacher teacher1 = new Teacher("Charles Borklee", false);
            Teacher teacher2 = new Teacher("Amanda Vines", true);

            var tArray = new Teacher[2];
            tArray[0] = teacher1;
            tArray[1] = teacher2;

            course.Teachers = tArray;

            Console.WriteLine($"The name of the University Program is {universityProgram.Name} and it contains the {degree.Name} degree.");
            Console.WriteLine($"The {degree.Name} currently contains the {course.Name} course.");
            Console.WriteLine($"There are {Student.studentCount} students currently enrolled.");
        }
    }
}
