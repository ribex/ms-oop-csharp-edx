namespace Module1TutorialLab2
{
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
        }

        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
        }
    }
}