// See https://aka.ms/new-console-template for more information

using Demo1;
using Demo1.builders;

/// Initialising builders
var motorcycleBuilder = new MotorcycleBuilder();
var carBuilder = new CarBuilder();

Console.WriteLine("------------------------Craeting MotorcycleObject---------------------");
/// creating motorcycle object
var motorcycleDirector = new Director();
motorcycleDirector.Construct(motorcycleBuilder);
var motorcycle = motorcycleBuilder.GetProduct();
motorcycle.ShowParts();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("------------------------Craeting CarObject---------------------");
/// creating car object
var carDirector = new Director();
carDirector.Construct(carBuilder);
var car = carBuilder.GetProduct();
car.ShowParts();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("------------------------Using Method Chaining---------------------");

var car2 = new CarBuilder2()
    .StartManufacturing()
    .AddEngine()
    .AddHeadlights()
    .InsertWheels()
    .AddSeats()
    .BuildBody()
    .GetProduct();
car2.ShowParts();


Console.WriteLine();
Console.WriteLine();


var motorcycle2 = new MotorcycleBuilder2()
    .StartManufacturing()
    .AddEngine()
    .AddHeadlights()
    .InsertWheels()
    .AddSeats()
    .BuildBody()
    .GetProduct();
motorcycle2.ShowParts();




