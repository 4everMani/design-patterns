using ObserverDesignPattern.Publisher;
using ObserverDesignPattern.Subscriber;

Console.WriteLine("Observer Design Pattern");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");


var emailSubsriber1 = new EmailSubscriber("Manish", "jaiswal.manish49@gmail.com");
var emailSubsriber2 = new EmailSubscriber("Krishu", "krishu49@gmail.com");
var emailSubsriber3 = new EmailSubscriber("Monu", "monu49@gmail.com");

var mobileSubscriber1 = new MobileSubscriber("Manish", "7870665600");
var mobileSubscriber2 = new MobileSubscriber("Raja", "7870665601");
var mobileSubscriber3 = new MobileSubscriber("Anupam", "7870665602");

var youtubeVideoPublisher = new YoutubeVideoPublisher();


youtubeVideoPublisher.AddSubscription(emailSubsriber1);
youtubeVideoPublisher.AddSubscription(emailSubsriber2);
youtubeVideoPublisher.AddSubscription(emailSubsriber3);
youtubeVideoPublisher.AddSubscription(mobileSubscriber1);
youtubeVideoPublisher.AddSubscription(mobileSubscriber2);
youtubeVideoPublisher.AddSubscription(mobileSubscriber3);


youtubeVideoPublisher.UploadVideo("Titanic");