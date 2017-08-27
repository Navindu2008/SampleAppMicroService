using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using System.Net.Http;

namespace SampleAppMicroService
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:8080/";

            // Start OWIN host 
            using (WebApp.Start(url: baseAddress))
            {
                Console.WriteLine("Service Listening at " + baseAddress);

                System.Threading.Thread.Sleep(-1);
            }
        }
    }
}
