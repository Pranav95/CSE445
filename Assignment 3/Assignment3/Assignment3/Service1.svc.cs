using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net;
using Porter2Stemmer;
namespace Assignment3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void DoWork()
        {
        }
        public string stemming(string webcontent)
        {
            //the code for stemming was already implemented online. I just added the project in my solution.
            EnglishPorter2Stemmer stem = new EnglishPorter2Stemmer();


            string[] words = webcontent.Split(' ');
            string stemmedwords = "";

            
            foreach(var word in words)
            {
                stemmedwords = stemmedwords + " " + stem.Stem(word).Value;
            }

            return stemmedwords;

        }
        public string WordFilter(string webcontent)
        {
            //list of all the stop words
            List<string> stopwords = new List<string>(new string[] { "i", "me", "my", "myself", "we", "our", "ours", "ourselves", "you", "your", "yours", "yourself", "yourselves", "he", "him", "his", "himself", "she", "her", "hers", "herself", "it", "its", "itself", "they", "them", "their", "theirs", "themselves", "what", "which", "who", "whom", "this", "that", "these", "those", "am", "is", "are", "was", "were", "be", "been", "being", "have", "has", "had", "having", "do", "does", "did", "doing", "a", "an", "the", "and", "but", "if", "or", "because", "as", "until", "while", "of", "at", "by", "for", "with", "about", "against", "between", "into", "through", "during", "before", "after", "above", "below", "to", "from", "up", "down", "in", "out", "on", "off", "over", "under", "again", "further", "then", "once", "here", "there", "when", "where", "why", "how", "all", "any", "both", "each", "few", "more", "most", "other", "some", "such", "no", "nor", "not", "only", "own", "same", "so", "than", "too", "very", "s", "t", "can", "will", "just", "don", "should", "now" });

            var words = webcontent.Split(' ');
            var newWords = words.Except(stopwords);

            string newString = string.Join(" ", newWords);

            return newString;

           
        }
        public void addMovie(string movie, string tags)
        {
            Movies mov = new Movies();
            mov.addMovie(movie, tags);
        }
        

    }
}
