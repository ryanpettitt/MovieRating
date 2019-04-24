using System.Collections.Generic;
using System.IO;
using System.Linq;

// TODO - Come up with a way to do hashing on passwords
namespace Web_Scraping
{
    
    public class UserHandler
    {
        public string username;
        public string password;
        private List<string> users;
        private List<string> passwords;


        public UserHandler(string ausername, string apassword)
        {
            username = ausername;
            password = apassword;
        }

        private void hUserHandler()
        {

            try
            {
                using (var reader = new StreamReader(@"Users.csv"))
                {
                    var listA = new List<string>();
                    var listB = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        listA.Add(values[0]);
                        listB.Add(values[1]);
                    }
                    users = listA.ToList();
                    passwords = listB.ToList();
                }
            }
            catch
            {
                string path = @"Users.csv";
                File.Create(path);
            }

        }

        public bool validate()
        {
            bool there = false;
            hUserHandler();
            try
            {
                if (users.Contains(username) && passwords.Contains(password))
                {
                    if (passwords[users.IndexOf(username)] == password)
                    {
                        there = true;
                    }
                }
            }
            catch
            {
                return false;
            }
            return there;
        }

        public void adduser()
        {

            string path = @"Users.csv";
            string data = username + "," + password + "\n";
            File.AppendAllText(path, data);
        }
    }
}
