using System;

namespace trainingday_6
{
    class Car
    {
        // this class "has" the following properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int TopSpeed { get; set; }
        public int CurrentSpeed { get; set; }
        public bool EngineRunning { get; set; }

        // this class "can do" the following methods
        public void StartEngine()
        {
            EngineRunning = true;
        }

        public void StopEngine()
        {
            EngineRunning = false;
        }

        public void Accelerate()
        {
            if (!EngineRunning)
            {
                Console.WriteLine("Cannot accelerate without the engine running.");
            }
            else
            {
                CurrentSpeed += 10;
                if (CurrentSpeed > TopSpeed)
                {
                    CurrentSpeed = TopSpeed;
                }
            }
        }

        public void Brake()
        {
            CurrentSpeed -= 10;
            if (CurrentSpeed < 0)
            {
                CurrentSpeed = 0;
            }
        }

        public void BrakeHard()
        {
            for (int i = 0; i < 5; i++)
            {
                Brake();
            }
        }
    }
}