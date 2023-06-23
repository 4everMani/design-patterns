using System;
using ObserverDesignPattern.Publisher;

namespace ObserverDesignPattern.Subscriber
{
	public class MobileSubscriber : ISubscriber
	{
        private string Name { get; set; }

        private string MobileNumber { get; set; }

        public MobileSubscriber(string name, string mobileNumber)
		{
            Name = name;
            MobileNumber = mobileNumber;
		}

        public void Notify(IPublisher publisher)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Hi {Name}({MobileNumber})");
            Console.WriteLine($"A new video is published with title: {publisher.GetData()}");
        }
    }
}

