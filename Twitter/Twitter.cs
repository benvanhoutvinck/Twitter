using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Twitter
{
    class Twitter
    {
        private Tweets tweetsValue;

        public Tweets Tweets
        {
            get
            {
                return tweetsValue;
            }
            set
            {
                this.tweetsValue = value;
            }

        }

        public Twitter()
        {
            this.tweetsValue = new Tweets();
        }

        public void addTweet(Tweet tweet)
        {
            ReadTweets();
            this.Tweets.addTweet(tweet);
            writeTweets();
        }

        public void ReadTweets()
        {
            try
            {
                using (var bestand = File.Open(@"C:\Data\twitter.obj", FileMode.Open, FileAccess.Read))
                {
                    var lezer = new BinaryFormatter();
                    this.Tweets = (Tweets)lezer.Deserialize(bestand);
                }
            }
            catch (SerializationException)
            {
                Console.WriteLine("Fout bij het deserialiseren");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void writeTweets()
        {
            try
            {
                using (var bestand = File.Open(@"C:\Data\twitter.obj", FileMode.OpenOrCreate))
                {
                    var schrijver = new BinaryFormatter();
                    schrijver.Serialize(bestand, this.Tweets);
                }
                Console.WriteLine("Serialisatie geslaagd");
            }
            catch (SerializationException)
            {
                Console.WriteLine("Fout bij het serialiseren");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
