using AbstractFactory.Factories;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modern Furniture");
            var modernFurnitureFActory = new ModernFurnitureFactory();
            var modernChair = modernFurnitureFActory.GetChair(); 
            var modernSofa = modernFurnitureFActory.GetSofa();  
            var modernTable = modernFurnitureFActory.GetTable();
            Console.WriteLine($"Cost of modern chair is: {modernChair.TotalCost()}");
            Console.WriteLine($"Cost of modern sofa is: {modernSofa.TotalCost()}");
            Console.WriteLine($"Cost of modern table is: {modernTable.TotalCost()}");

            Console.WriteLine("\n");

            Console.WriteLine("Classic Furniture");
            var claasicFurnitureFActory = new ClassicFurnitureFactory();
            var classicChair = claasicFurnitureFActory.GetChair();
            var classicSofa = claasicFurnitureFActory.GetSofa();
            var classicTable = claasicFurnitureFActory.GetTable();
            Console.WriteLine($"Cost of classic chair is: {classicChair.TotalCost()}");
            Console.WriteLine($"Cost of classic sofa is: {classicSofa.TotalCost()}");
            Console.WriteLine($"Cost of classic table is: {classicTable.TotalCost()}");

            Console.WriteLine("\n");

            Console.WriteLine("Traditional Furniture");
            var traditionalFurnitureFActory = new TraditionalFurnitureFactory();
            var traditionalChair = traditionalFurnitureFActory.GetChair();
            var traditionalSofa = traditionalFurnitureFActory.GetSofa();
            var traditionalTable = traditionalFurnitureFActory.GetTable();
            Console.WriteLine($"Cost of traditional chair is: {traditionalChair.TotalCost()}");
            Console.WriteLine($"Cost of traditional sofa is: {traditionalSofa.TotalCost()}");
            Console.WriteLine($"Cost of traditional table is: {traditionalTable.TotalCost()}");
        }
    }
}