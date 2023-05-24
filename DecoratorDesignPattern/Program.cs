// See https://aka.ms/new-console-template for more information
using System;
using DecoratorDesignPattern.Example1;
using DecoratorDesignPattern.Example2;

Console.WriteLine("Example 1");
Console.WriteLine();
Console.WriteLine("Constructing base home");
Console.WriteLine();

// Creating base home

AbstractHome home = new ConcreteHome();

// Creating base home and adding additional floor

home = new FloorDecorator(home);
home.MakeHome();

// Creating base home and painting the house

home = new PaintDecorator(home);
home.MakeHome();


Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Example 2");
Console.WriteLine();

// Creating base pizza
Console.WriteLine("Creating base pizza");
AbstractPizza basePizza = new BasePizza(100);
Console.WriteLine($"Cost of base pizza: {basePizza.TotalCost()}");

Console.WriteLine("Adding onion topping");
AbstractPizza pizzaWithOnionTopping = new OnionTopping(basePizza);
Console.WriteLine($"Cost of pizza with onion topping: {pizzaWithOnionTopping.TotalCost()}");

Console.WriteLine("Adding chilli topping");
AbstractPizza pizzaWithChilliAndOnionTopping = new ChilliTopping(pizzaWithOnionTopping);
Console.WriteLine($"Cost of pizza with onion topping: {pizzaWithChilliAndOnionTopping.TotalCost()}");





