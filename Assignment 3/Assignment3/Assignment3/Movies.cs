using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3
{

    public class Movies
    {
        static  List<List<string>> moviesMap;
        public Movies()
        {
            moviesMap = new List<List<string>>();
            moviesMap.Add(new List<string> { "Interstellar", "Drama Space Spectacular Fascinating illusion" });
            moviesMap.Add(new List<string> { "The Prestige", "magician secret illusion obsession" });
            moviesMap.Add(new List<string> { "Inception", "psycho thriller subconscious dream" });
            moviesMap.Add(new List<string> { "The Shawshank Redemption", "prison friendship escape Andy" });
            moviesMap.Add(new List<string> { "The Godfather", "mafia crime organized rise" });
            moviesMap.Add(new List<string> { "Fight Club", "fighting multiple disorder personality" });
        }
        public string getMovie(List<string> tags)
        {
            int current = 9999;
            String movie = "";
            foreach (var mo in moviesMap)
            {
                List<String> s1 = mo[1].Split(' ').ToList();
                var c = s1.Except(tags).ToList();
                if (c.Count < current)
                {
                    current = c.Count;
                    movie = mo[0];
                }
                
            }
            if (current == 9999)
                movie = "No such Movie in Database";
            return movie;
        }
        public string getMovies(string id)
        {
            string mov = "";
            Int32 id1 = Int32.Parse(id);
            if (id1 > moviesMap.Count())
                mov = "Enter some another number";

            mov = moviesMap[id1][0];
            return mov;
        }
        public string getKeywords(string id)
        {
            string keywords = "Movie not found";
            foreach (var mo in moviesMap)
            {
                if (mo[0] == id)
                    keywords = mo[1];

            }
            return keywords;

        }
        public void addMovie(string movie, string tags)
        {
            moviesMap.Add(new List<string> { movie, tags });
        }
    }
}