using System;
namespace StrategyPattern.Strategies
{
	public class CabStrategy : IStrategy
	{
        public decimal CalculateFare(decimal distance)
        {
            return 7 * distance;
        }
    }
}

