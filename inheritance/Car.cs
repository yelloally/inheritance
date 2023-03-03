using System;
namespace inheritance
{
    //derived class called "Car" that inherits from the "Vehicle"
    class Car : Vehicle
    {
        public Car(string make, string model, int year) : base(make, model, year) { }
            public override void Drive()
        {
            Console.WriteLine($"The {Year} {Make} {Model} is driving on the road.");
        }

        public void Park()
        {
            Console.WriteLine($"The {Year} {Make} {Model} is parked.");
        }
        
    }
}




