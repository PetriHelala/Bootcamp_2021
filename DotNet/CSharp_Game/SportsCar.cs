using System;

namespace trainingday_6
{   
    // Example of deriving a new class from an existing class
    // Child/derived class: SportsCar
    // Base/mother: Car   
    
    class SportsCar : Car
    {
        public bool RoofDown { get; set; }
    }
    
    /*
    Oma testi tästä perimisestä ja juontamisesta... Ei toimi vielä.

    class CarLights : Car
    {
        public void CarLightsOn()
        {
            if(EngineRunning) 
            {
                Console.WriteLine("Car lights went on.");
            }
            if(!EngineRunning) 
            {
                Console.WriteLine("Car lights went out.");
            }
        }
    }
    */
}
