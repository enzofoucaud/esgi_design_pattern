using System;

namespace esgi_design_pattern
{
    public class Factory
    {
        private static Factory _instance;
        public string Name { get; set; }
        private Factory(){}
        public static Factory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Factory();
            }
            return _instance;
        }
        public void Display()
        {
            Console.WriteLine("Factory: " + Name);
        }
        public Car BuildCar(string company, string brand)
        {
            return new Car(company, brand);
        }
    }
}