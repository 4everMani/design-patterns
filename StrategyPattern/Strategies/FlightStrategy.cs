using System;
namespace StrategyPattern.Strategies
{
	public class FlightStrategy : IStrategy
	{
        public decimal CalculateFare(decimal distance)
        {
            return 30 * distance;
        }
    }
}

