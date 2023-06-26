using StrategyPattern;
using StrategyPattern.Strategies;

Console.WriteLine("Strategy design pattern");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Get travel fare based on distance");
Console.WriteLine();
Console.Write("Enter the distance between source and destination: ");

var distance = decimal.Parse(Console.ReadLine());

var fareContext = new FareContext();

if(distance <= 50)
{
    fareContext.SetStrategy(new CabStrategy());
    Console.WriteLine(fareContext.GetFare(distance));
}
else if(distance > 50 && distance <= 300)
{
    fareContext.SetStrategy(new TrainStrategy());
    Console.WriteLine(fareContext.GetFare(distance));
}
else if(distance > 301)
{
    fareContext.SetStrategy(new FlightStrategy());
    Console.WriteLine(fareContext.GetFare(distance));
}






