namespace Module1TutorialLab2
{
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        private static int instances = 0;

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }

        public Car()
        {
            instances++; // increment each time a new Car object is constructed
        }

        public static int CountCars()
        {
            return instances;
        }
    }
}