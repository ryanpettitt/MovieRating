using System;
using System.Windows.Forms;
using RestSharp;
using System.IO;
using System.Text;

namespace Web_Scraping
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO - Think of a way to remove the cmd from the background
            ///Console.SetWindowSize(4, 4);
            if (!File.Exists(@"json.txt"))
            {
                data();
            }
            Application.Run(new LogIn());
            Console.ReadLine();
        }

        static void data()
        {
            string api = "https://api.themoviedb.org/3/discover/movie?api_key=2c9dcdf506c5c68d631b29d39fab92e4&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false";

            var client = new RestClient(api);
            var request = new RestRequest(Method.GET);
            request.AddParameter("undefined", "{}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var tx = File.OpenWrite(@"json.txt");
            byte[] info = new UTF8Encoding(true).GetBytes(response.Content);
            tx.Write(info, 0, info.Length);
        }
    }
}
