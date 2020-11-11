using System;
namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        {
        }
        public bool IsFast { get; set; }
        public string TrunkSize { get; set; }

        public int DoorAmount { get; set; } = 4;
        public bool isFourTires { get; set; } = true;
        public string Windows { get; set; } = "are light";
        public string Color { get; set; } = "silver";
        public string Salary { get; set; } = "The salesman recieved 3% commission for selling the car.";
        public string DressCode { get ; set ; } = "The staff dresses professionally.";

        public bool HasChangedGears { get; set; }


        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward");
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} change gear to park");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in reverse");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} change gear to reverse");
            }
        }

        
           
        
    }

        
    
}
