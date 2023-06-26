using System;
namespace StrategyPattern.Strategies
{
	public class TrainStrategy : IStrategy
	{
        public decimal CalculateFare(decimal distance)
        {
            return 2 * distance;
        }
    }
}

