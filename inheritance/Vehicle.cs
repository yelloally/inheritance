using System;


namespace inheritance
{
    //base class
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public virtual void Drive()
        {
            Console.WriteLine("The vehicle is being driven.");
        }
    }
}

