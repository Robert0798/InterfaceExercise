using System;

namespace InterfaceExercise
{
    public class Suv : IVehicle , ICompany
    {
        public Suv()
        {
        
        }

        public double EngineSize { get; set; } = 5;
        public string Make { get; set; } = "Mercedes";
        public string Model { get; set; } = "G wagon";
        public int SeatCount { get; set; } = 6;
        public string CompanyName { get; set; } = "Mercedes";
        public string Motto { get; set; } = "we do not speak poor";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward. . .");
            }
            else
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward. . ."); 
            }
            Console.WriteLine($"{GetType().Name} now driving forward!. . .");
        }

        public void Reverse()
        
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving reversing. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
            
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}

