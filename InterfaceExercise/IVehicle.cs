using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int DoorAmount { get; set; } 
        public bool isFourTires { get; set; }
        public string Windows { get; set; }
        public string Color { get; set; }


        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);
        
    }

   
}
