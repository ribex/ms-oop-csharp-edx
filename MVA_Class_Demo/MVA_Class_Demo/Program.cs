using System;
using System.IO.Pipes;

namespace MVA_Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine();
            myMachine._location = "Kitchen";
            myMachine._model = "DM1000";

            Console.WriteLine(myMachine._location);
            myMachine.MakeCappuccino();
        }
    }
}
