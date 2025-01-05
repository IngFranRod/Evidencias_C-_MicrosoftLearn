using CodeLibrary;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapWebpage("https://msdn.microsoft.com");
            Console.Write(value);

        }
    }

}