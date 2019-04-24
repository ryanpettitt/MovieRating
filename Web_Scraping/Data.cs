using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;


namespace Web_Scraping
{
    class Data
    {
        /// <summary>
        /// Returns titles of movies
        /// </summary>
        /// <returns></returns>
        public List<string> Gethtml()
        {
            var tx = File.ReadAllText(@"json.txt");
            var movies = JsonConvert.DeserializeObject<Movie_data>(tx.ToString());
            return movies.write();
        }
        /// <summary>
        /// returns a class object
        /// </summary>
        /// <param name="user"> current user</param>
        /// <param name="review"> review of the current user</param>
        /// <param name="moviewtitle"> the title that user reviewed</param>
        /// <returns></returns>
        public Movie_data data(string user, string review, string moviewtitle)
        {
            var tx = File.ReadAllText(@"json.txt");
            System.Console.WriteLine(tx);
            Movie_data movies = JsonConvert.DeserializeObject<Movie_data>(tx.ToString());
            foreach (var item in movies.results)
            {
                if (moviewtitle == item.title)
                {
                    //JObject rss = JObject.Parse(tx);

                    //JObject channel = (JObject)rss["results"];
                    //channel.Property("description").AddAfterSelf(new JProperty("reviews", "[]"));
                    //JArray part = (JArray)channel["reviews"];
                    //part.Add(user);
                    //part.Add(review);
                }
            }
            // TODO - fix this so that the null value in item.reviews doesnt break it. thought this might work but no luck
            return movies;
        }
        /// <summary>
        /// Saves a json file
        /// </summary>
        /// <param name="json"> This is the object you would like to save </param>
        public void savejson(Movie_data json)
        {
            var data = JsonConvert.SerializeObject(json);
            File.WriteAllText(@"json.txt", data);
        }
    }
}
