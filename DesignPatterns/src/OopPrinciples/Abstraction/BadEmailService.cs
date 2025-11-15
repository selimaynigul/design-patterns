using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Abstraction
{
    public class BadEmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending email...");
        }

        public void Connect()
        {
            Console.WriteLine("Connecting...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting...");
        }

        public void Authenticate()
        {
            Console.WriteLine("Authenticating...");
        }

    }
}