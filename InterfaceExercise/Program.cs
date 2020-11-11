using System;
using System.Collections.Generic;


namespace InterfaceExercise
{
    class Program
    {
        //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

        //Create 2 Interfaces called IVehicle & ICompany--DONE

        //Create 3 classes called Car , Truck , & SUV--DONE

        //In your IVehicle--DONE

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */


        //In ICompany

        /*Create 2 members that are specific to each every company
         * regardless of vehicle type.
         *
         *
         * Example: public string Logo { get; set; }
         */

        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size--DONE
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.--DONE
         * 
         */

        //Now, create objects of your 3 classes and give their members values;
        //Creatively display and organize their values

        static void Main(string[] args)
        {
            Car car= new Car();

            Truck truck = new Truck();

            SUV suv = new SUV();

            var vehhicles = new List<IVehicle> { car, truck, suv };

            var company = new List<ICompany> { car, truck, suv };

            foreach(var vehicle in vehhicles)
            {
               vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
                Console.WriteLine(vehicle.Salary);
                Console.WriteLine(vehicle.DressCode);

                Console.WriteLine($"The vehicle has {vehicle.DoorAmount} doors. The vehicle is {vehicle.Color}. " +
                $"There are 4 tires on this vehicle: {vehicle.isFourTires = false}. The windows {vehicle.Windows} ");

               

                Console.WriteLine("------------------");

            }
            
        }
    }
}
