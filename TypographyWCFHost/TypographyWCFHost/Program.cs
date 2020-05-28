using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Typography_WCF;

namespace TypographyWCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Typography_WCF.WorkClasses), new Uri("http://localhost:8733/Design_Time_Addresses/Typography_WCF/Service1/"));
            host.AddServiceEndpoint(typeof(Typography_WCF.IClasses), new BasicHttpBinding(), "");


            host.Open();

            Console.WriteLine("Служба запущенна");

            Console.ReadLine();

            host.Close();
        }
    }
}
