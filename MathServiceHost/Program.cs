using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Description;
using MathTypes;

namespace MathServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri LocalAddress = new Uri(ConfigurationManager.AppSettings["baseAddress"]);
            ServiceHost host = new ServiceHost(typeof(MathService), LocalAddress);

            host.AddServiceEndpoint(typeof(IMath), new BasicHttpBinding(), "math");
            host.Open();

            Console.WriteLine("MathService is listening to the following");
            foreach (ServiceEndpoint e in host.Description.Endpoints)
            {
                Console.WriteLine("{0} ({1})", e.Address.ToString(), e.Binding.Name);
            }

            Console.WriteLine("\n Press Enter to terminate...");
            Console.ReadKey();
        }
    }
}
