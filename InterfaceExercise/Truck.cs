using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public int LiftHeight { get; set; }
        public string BedSize { get; set; }

        public int DoorAmount { get; set; } = 2;
        public bool isFourTires { get; set; } = false ;
        public string Windows { get; set; } = "are tinted";
        public string Color { get; set; } = "red";
        public string Salary { get; set; } = "The salesman recieved 5% commission for selling the truck.";
        public string DressCode { get; set; } = "The staff dresses casually.";

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