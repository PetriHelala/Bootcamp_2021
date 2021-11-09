using System;

namespace trainingday_6
{
    class Customer
    {
        // properties (data)
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        // methods (functionality)
        public void Print()
        {
            Console.WriteLine("Customer name: " + Name);
            Console.WriteLine("Customer address: " + Address);
            Console.WriteLine("Customer zip: " + ZipCode);
            Console.WriteLine("Customer city: " + City);
        }
    }
}