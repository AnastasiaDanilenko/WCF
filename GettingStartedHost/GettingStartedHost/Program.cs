using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using GettingStartedLib;
using System.ServiceModel.Description;

namespace GettingStartedHost
{
    class Program
    {
        static void Main(string[] args)
        {


            ServiceHost selfHost = new ServiceHost(typeof(ServiceChat));
            try
            {
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}
