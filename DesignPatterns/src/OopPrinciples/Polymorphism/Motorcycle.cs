using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Polymorphism
{
    public class Motorcycle : VehiclePolymorphism
    {

        public override void Start()
        {
            Console.WriteLine("Motorcycle started.");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle stopped.");
        }
        
    }
}