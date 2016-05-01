using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Twitter twitter = new Twitter();

            Tweet tweet = new Tweet();
            Console.Write("Geef je naam in:");
            tweet.Naam = Console.ReadLine();
            Console.Write("Geef je tweet in:");
            tweet.Bericht = Console.ReadLine();

            twitter.addTweet(tweet);

            foreach (var temp in twitter.Tweets.tweetsList)
            {
                Console.Write(temp);
            }
        }
    }
}
