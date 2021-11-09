using System;

namespace trainingday_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance (object) of the Customer class
            Customer first = new();
            first.Name = "Jane Doe";
            first.Address = "Wintergarden 123";
            first.ZipCode = "88200";
            first.City = "Snowy City";
            // first.Print();

            // create a second instance (object) of the Customer class
            Customer second = new();
            second.Name = "Tom Tester";
            second.Address = "Homestreet 6 B";
            second.ZipCode = "51000";
            second.City = "Vaasa";
            // second.Print();

            // *********** car demo ***********
            /*
            Car myCar = new();
            myCar.Make = "Ford";
            myCar.Model = "S-Max";
            myCar.TopSpeed = 210;
            myCar.StartEngine();
            myCar.Accelerate();
            Car neighborsCar = new();
            neighborsCar.Make = "Toyota";
            neighborsCar.Model = "Corolla";
            myCar.TopSpeed = 190;
            myCar.StartEngine();
            myCar.Accelerate();
            */

            // testing functionalities
            Console.WriteLine("Car testing starts.");
            Car testCar = new();
            testCar.TopSpeed = 25;
            testCar.StartEngine();
            testCar.Accelerate();
            testCar.Accelerate();
            testCar.Accelerate();
            testCar.Brake();
            Console.WriteLine("The testing car's current speed is: " + testCar.CurrentSpeed);

            SportsCar sport = new();
            sport.RoofDown = true;
            sport.StartEngine();

            /*
            string customerName = "Cecilia Customer";
            string customerAddress = "Homestreet 1 B 17";
            string customerZipCode = "40520";
            string customerCity = "Vaasa";
            PrintCustomer(customerName, customerAddress, customerZipCode, customerCity);
            string customer2Name = "John Doe";
            string customer2Address = "Pine Street 5 C";
            string customer2ZipCode = "40550";
            string customer2City = "Vaasa";
            PrintCustomer(customer2Name, customer2Address, customer2ZipCode, customer2City);
            */
        }

        // private static void PrintCustomer(string name, string address, string zip, string city)
        // {
        //     Console.WriteLine("Customer name: " + name);
        //     Console.WriteLine("Customer address: " + address);
        //     Console.WriteLine("Customer zip: " + zip);
        //     Console.WriteLine("Customer city: " + city);
        // }
    }
}