using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace namespaces
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
           
            WebClient client = new WebClient();
            string reply = client.DownloadString("Http://msdn.microsoft.com");

            Console.WriteLine(reply);

            //gets full page html to file
            File.WriteAllText(@"C:\Users\frany\OneDrive\Escritorio\Learn\21-Namespace\WriteText.txt", reply);

            Console.ReadLine();
        }
    }
}