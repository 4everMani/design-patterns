// See https://aka.ms/new-console-template for more information
using FactoryMethod;

IShipment airShipment = new AirShipmentFactory().GetShipmentObject();
Console.WriteLine($"Total chrages of air shipment is: {airShipment.calculateTotalCharges()}");
Console.WriteLine();
Console.WriteLine($"Total time taken by air shipment is: {airShipment.TotalTimeTakes()}");


IShipment landShipment = new LandShipmentFactory().GetShipmentObject();
Console.WriteLine($"Total chrages of land shipment is: {landShipment.calculateTotalCharges()}");
Console.WriteLine();
Console.WriteLine($"Total time taken by land shipment is: {landShipment.TotalTimeTakes()}");
