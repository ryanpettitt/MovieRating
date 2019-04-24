using System;
using System.Collections.Generic;


namespace Web_Scraping
{
    class Movie_data
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public List<result> results { get; set; }

        public class result
        {
            public int vote_count { get; set; }
            public int id { get; set; }
            public bool video { get; set; }
            public double vote_average { get; set; }
            public string title { get; set; }
            public double popularity { get; set; }
            public string poster_path { get; set; }
            public string original_language { get; set; }
            public string original_title { get; set; }
            public string backdrop_path { get; set; }
            public bool adult { get; set; }
            public string overview { get; set; }
            public DateTime release_date { get; set; }
            public List<userreview> reviews { get; set; }
        }
        public class userreview
        {
            public string user { get; set; }
            public string review { get; set; }
        }
        
        /// <summary>
        /// This function will Return a list of Movie titles
        /// </summary>
        public List<string> write()
        {
            List<string> data = new List<string>(); 
            foreach (var item in results)
            {
                data.Add(item.title.ToString());
            }
            return data;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns a list of reviews</returns>
        public List<string> review()
        {
            List<string> data = new List<string>();
            foreach (var item in results)
            {
                foreach(var part in item.reviews)
                {
                    data.Add(part.review.ToString());
                }
            }
            return data;
        }
    }
}
