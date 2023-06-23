using System;
using ObserverDesignPattern.Subscriber;

namespace ObserverDesignPattern.Publisher
{
	public class YoutubeVideoPublisher : IPublisher
	{
        private List<ISubscriber> _subscriberList;

        private string _videoTitle;

		public YoutubeVideoPublisher()
		{
            _subscriberList = new List<ISubscriber>();
		}

        public void AddSubscription(ISubscriber subscriber)
        {
            _subscriberList.Add(subscriber);
        }

        public void NotifySubscribers()
        {
            if (_subscriberList.Count is 0) return;

            foreach(ISubscriber subscriber in _subscriberList)
            {
                subscriber.Notify(this);
            }
        }

        public void RemoveSubscription(ISubscriber subscriber)
        {
            _subscriberList.Remove(subscriber);
        }

        public void UploadVideo(string videoTitle)
        {
            _videoTitle = videoTitle;
            Console.WriteLine("Video uploading started");

            Thread.Sleep(10000);

            Console.WriteLine("Video uploaded successfully!");

            Thread.Sleep(10000);

            NotifySubscribers();

        }

        public string GetData()
        {
            return _videoTitle;
        }
    }
}

