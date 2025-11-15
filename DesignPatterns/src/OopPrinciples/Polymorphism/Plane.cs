using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Polymorphism
{
    public class Plane : VehiclePolymorphism
    {

        public override void Start()
        {
            Console.WriteLine("Plane started.");
        }

        public override void Stop()
        {
            Console.WriteLine("Plane stopped.");
        }
        
    }
}