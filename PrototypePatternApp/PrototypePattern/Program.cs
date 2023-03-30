// See https://aka.ms/new-console-template for more information
using PrototypePattern;

BasicCar car1 = new Innova();

Console.WriteLine($"Name of car is {car1.CarName} & price is {car1.Price + BasicCar.AddTaxes()}");

BasicCar car2 = new Tesla();

Console.WriteLine($"Name of car is {car2.CarName} & price is {car2.Price + BasicCar.AddTaxes()}");

// Copying objects

Console.WriteLine("Displaying copied objects");

BasicCar copyCar1 = car1.GetClone();
copyCar1.CarName = "Innova S1";
Console.WriteLine($"Name of car is {copyCar1.CarName} & price is {copyCar1.Price + BasicCar.AddTaxes()}");

BasicCar copyCar2 = car2.GetClone();
copyCar2.CarName = "Tesla V2";
Console.WriteLine($"Name of car is {copyCar2.CarName} & price is {copyCar2.Price + BasicCar.AddTaxes()}");
