using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending email...");
            Disconnect();
        }

        private void Connect()
        {
            Console.WriteLine("Connecting...");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting...");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticating...");
        }

         
    }
}