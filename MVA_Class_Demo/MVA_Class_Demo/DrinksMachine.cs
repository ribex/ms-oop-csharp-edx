using System;

namespace MVA_Class_Demo
{
    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }

        // The following statements declare private member variables
        private string _location;
        private string _make;
        private string _model;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // The following statements declare public methods
        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino is made.");
        }
        public void MakeEspresso()
        {
            // Method logic goes here
        }
    }
}
