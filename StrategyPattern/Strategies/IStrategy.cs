using System;
namespace StrategyPattern.Strategies
{
	public interface IStrategy
	{
		decimal CalculateFare(decimal distance);
	}
}

