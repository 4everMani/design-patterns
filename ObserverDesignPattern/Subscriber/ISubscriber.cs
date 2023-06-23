using System;
using ObserverDesignPattern.Publisher;

namespace ObserverDesignPattern.Subscriber
{
	public interface ISubscriber
	{
		void Notify(IPublisher publisher);
	}
}

