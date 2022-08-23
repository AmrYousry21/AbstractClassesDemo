using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleUI.Program;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year = "2019";
        public string Make = "Toyota";
        public string Model = "Corolla";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is Virtual");
        }
    }

    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            bool hasTrunk = true;
            Console.WriteLine($"Has trunk ? {hasTrunk}");
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            bool sideCart = true;
            Console.WriteLine($"Has trunk ? {sideCart}");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
            Console.WriteLine("This is Virtual override");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            Car car = new Car();
            vehicles.Add(car);  
            
            Motorcycle motorcycle = new Motorcycle();
            vehicles.Add(motorcycle);

            Vehicle vehicleOne = new Car();
            vehicles.Add(vehicleOne);

            Vehicle vehicleTwo = new Motorcycle();
            vehicles.Add(vehicleTwo);
            
            foreach (Vehicle vehicle in vehicles) 
            {
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.Year);

                Console.WriteLine();

                vehicle.DriveVirtual();
                vehicle.DriveAbstract();

                Console.WriteLine();
            }   

        }
    }
}

