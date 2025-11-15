using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Polymorphism
{
    public class Truck : VehiclePolymorphism
    {
        public int NumberOfDoors { get; set; }

        public override void Start()
        {
            Console.WriteLine("Car started.");
        }

        public override void Stop()
        {
            Console.WriteLine("Car stopped.");
        }
    }
}