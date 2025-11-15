
using DesignPatterns.src.OopPrinciples.Encapsulation;
using DesignPatterns.src.OopPrinciples.Abstraction;
using DesignPatterns.src.OopPrinciples.Inheritance;
using DesignPatterns.src.OopPrinciples.Polymorphism;

// Encapsulation Example: BadBankAccount.cs
BadBankAccount badAccount = new BadBankAccount();
badAccount.balance = 1000m; // Direct access to the Balance field
Console.WriteLine($"Bad Account Balance: {badAccount.balance}");

BankAccount goodAccount = new BankAccount(1000m);
goodAccount.Deposit(500m);
goodAccount.Withdraw(200m);
Console.WriteLine($"Good Account Balance: {goodAccount.GetBalance()}");

// Abstraction Example: EmailService.cs
BadEmailService badEmailService = new BadEmailService();
badEmailService.Connect();
badEmailService.Authenticate();
badEmailService.SendEmail();
badEmailService.Disconnect();
Console.WriteLine();
EmailService goodEmailService = new EmailService();
goodEmailService.SendEmail();


// Inheritance Example: Car.cs, Bike.cs, Vehicle.cs
 var myCar = new Car();
    myCar.Brand = "Toyota";
    myCar.Model = "Camry";
    myCar.Year = 2020;
    myCar.NumberOfDoors = 4;
    myCar.NumberOfWheels = 4;
    myCar.Start();
    myCar.Stop();

var myBike = new Bike();
myBike.Brand = "Yamaha";    
myBike.Model = "YZF-R3";
myBike.Year = 2021;
myBike.Start();
myBike.Stop();


// Polymorphism Example: Car.cs, Motorcycle.cs, Plane.cs, Vehicle.cs
List<VehiclePolymorphism> vehicles = new List<VehiclePolymorphism>();
vehicles.Add(new Truck { Brand = "Honda", Model = "Civic", Year = 2019, NumberOfDoors = 4 });
vehicles.Add(new Motorcycle{ Brand = "Harley-Davidson", Model = "Street 750", Year = 2018 });

foreach (var vehicle in vehicles)
{
    vehicle.Start();
    vehicle.Stop();
}