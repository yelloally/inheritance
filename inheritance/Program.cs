using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //create objects of "Car" and "Motorcycle" and call their methods
            Car myCar = new Car("Toyota", "Camry", 2020);
            myCar.Drive();
            myCar.Park();

            Motorcycle myBike = new Motorcycle("Harley-Davidson", "Sportster", 2018);
            myBike.Drive();
            myBike.Wheelie();
        }
    }

   
}
