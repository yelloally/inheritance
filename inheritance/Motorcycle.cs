using System;
namespace inheritance
{
    //derived class called "Motorcycle" that also inherits from the "Vehicle"
	class Motorcycle : Vehicle
	{
        public Motorcycle(string make, string model, int year) : base(make, model, year) { }

        public override void Drive()
        {
            Console.WriteLine($"The {Year} {Make} {Model} is riding on the road.");
        }

        public void Wheelie()
        {
            Console.WriteLine($"The {Year} {Make} {Model} is doing a wheelie.");
        }

    }
}

