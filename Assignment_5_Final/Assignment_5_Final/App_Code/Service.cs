using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public void DoWork()
    {
    }
    public string getQoute()
    {
        Class1 ob = new Class1();
        return ob.getRandomQuote();
    }
}

public class Class1
{
    List<string> quotes;
    public Class1()
    {
        quotes = new List<string>();
        quotes.Add("Strive not to be a success, but rather to be of value. –Albert Einstein");
        quotes.Add("Two roads diverged in a wood, and I—I took the one less traveled by, And that has made all the difference.  –Robert Frost");
        quotes.Add("I attribute my success to this: I never gave or took any excuse. –Florence Nightingale");
        quotes.Add("You miss 100% of the shots you don’t take. –Wayne Gretzky");
        quotes.Add("Every strike brings me closer to the next home run. –Babe Ruth");
        quotes.Add("Definiteness of purpose is the starting point of all achievement. –W. Clement Stone");
        quotes.Add("Life isn't about getting and having, it's about giving and being. –Kevin Kruse");
        quotes.Add("Life is 10% what happens to me and 90% of how I react to it. –Charles Swindoll");
        quotes.Add("The mind is everything. What you think you become.  –Buddha");
        quotes.Add("An unexamined life is not worth living. –Socrates");



    }
    public string getRandomQuote()
    {
        Random rnd = new Random();
        int r = rnd.Next(this.quotes.Count);
        return quotes[r];
    }
}