using System;

namespace esgi_design_pattern
{
    public class Company
    {
        private string _name;
        // setter
        public void SetName(string name)
        {
            _name = name;
        }
        // getter
        public string GetName()
        {
            return _name;
        }
    }
    public class Brand
    {
        private string _name;
        // setter
        public void SetName(string name)
        {
            _name = name;
        }
        // getter
        public string GetName()
        {
            return _name;
        }
    }
    public class Car
    {
        // we need a new instance of Company and Brand object to create a new car
        Company _company = new Company();
        Brand _brand = new Brand();
        // constructor
        public Car(string company, string brand)
        {
            _company.SetName(company);
            _brand.SetName(brand);
        }
        // display all properties of the car
        public void DisplayAll()
        {
            Console.WriteLine("Company: " + _company.GetName());
            Console.WriteLine("Brand: " + _brand.GetName());
        }
    }
}