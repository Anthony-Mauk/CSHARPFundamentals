using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public enum VehicleType { Car, Truck, Motorcycle, Spaceship, SUV, Tractor, Boat, FlyingBison }
    // must make part of vehicle class after creating - add to list of properties
    public class Vehicle
    {
        //classes can have properties and methods
        //1 Access Modifier
        //2 Type
        //3 Name of Property - Pascal Case
        //4 Getters and Setters
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
    }
}
