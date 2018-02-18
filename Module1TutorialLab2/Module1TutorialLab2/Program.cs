using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1TutorialLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car();

            Car1.Color = "Cool Grey Khaki";
            Car1.Year = 2018;
            Car1.Mileage = 5;

            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");

            var Car2 = new Car("Cherry Red", 2008);
        }
    }
}
