using System.Net;

namespace CodeLibrary
{
    public class Scrape
    {

        public string ScrapWebpage(string url)
        {
           return GetWebpage(url);
        }

        public string ScrapWebpage(string url, string filepath)
        {
            string reply = GetWebpage(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
