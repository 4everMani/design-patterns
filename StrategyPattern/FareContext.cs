using System;
using StrategyPattern.Strategies;

namespace StrategyPattern
{
	public class FareContext
	{
		private IStrategy _strategy;

		public void SetStrategy(IStrategy strategy)
		{
			_strategy = strategy;
		}

		public decimal GetFare(decimal distance)
		{
			return _strategy.CalculateFare(distance);
		}
	}
}

