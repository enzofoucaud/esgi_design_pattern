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
            /* Chain of responsability */
            Console.WriteLine("--- Chain of responsability ---");
            // Create handlers
            var seller = new SellerHandler();
            var mechanic = new MechanicHandler();
            var assistance = new TechnicalAssistanceHandler();
            // Set the next handler in the chain
            seller.SetNext(mechanic).SetNext(assistance);
            Console.WriteLine("Chain of responsability: Seller -> Mechanic -> Technical assistance");
            Client.ClientCode(seller);
            Console.WriteLine();

            Console.WriteLine("Chain of responsability: Mechanic -> Technical assistance");
            Client.ClientCode(mechanic);
        }
    }
}