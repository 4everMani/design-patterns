using System;
using ObserverDesignPattern.Publisher;

namespace ObserverDesignPattern.Subscriber
{
	public class EmailSubscriber : ISubscriber
	{
        private string Name { get; set; }

        private string Email { get; set; }

        public EmailSubscriber(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void Notify(IPublisher publisher)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Hi {Name}({Email})");
            Console.WriteLine($"A new video is published with title: {publisher.GetData()}");
        }
    }
}

