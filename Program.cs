using System;

namespace esgi_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Composition */
            Console.WriteLine("--- Composition ---");
            // Set properties of the car
            var companyName = "Ford";
            var brandName = "Focus";
            // Create a new car
            var car = new Car(companyName, brandName);
            // Display all properties of the car
            car.DisplayAll();
            /* Singleton */
            Console.WriteLine("--- Singleton ---");
            // Get the instance of the factory
            var factoryFord = Factory.GetInstance();
            // Set the name of the factory
            factoryFord.Name = "Ford Motor Credit Company";
            // Display the name of the factory
            factoryFord.Display();
            // Create a new car using the factory and display all properties of the car
            factoryFord.BuildCar(companyName,brandName).DisplayAll();
        }
    }
}