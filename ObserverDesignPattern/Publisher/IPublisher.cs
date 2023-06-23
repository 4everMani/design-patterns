using System;
using ObserverDesignPattern.Subscriber;

namespace ObserverDesignPattern.Publisher
{
	public interface IPublisher
	{
		void AddSubscription(ISubscriber subscriber);

		void RemoveSubscription(ISubscriber subscriber);

		void NotifySubscribers();

		string GetData();
	}
}

