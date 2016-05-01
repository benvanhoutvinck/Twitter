using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    [Serializable]
    class Tweets
    {
        private List<Tweet> tweetsListValue;

        public ReadOnlyCollection<Tweet> tweetsList
        {
            get { return new ReadOnlyCollection<Tweet>(tweetsListValue); }
            set { tweetsListValue = value.ToList(); }
        }

        public Tweets()
        {
            this.tweetsListValue = new List<Tweet>();
        }

        public void addTweet(Tweet tweet)
        {
            tweet.Tijdstip = DateTime.Now;
            this.tweetsListValue.Add(tweet);
        }
    }
}
