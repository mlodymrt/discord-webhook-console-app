using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter webhook:");
            string webhook = Console.ReadLine();
            var wbc = new WebClient();
            var data = new NameValueCollection();

            while (true)
            {
                data["content"] = Console.ReadLine();
                wbc.UploadValues(webhook, data);
            }

        }

        
    }
}
