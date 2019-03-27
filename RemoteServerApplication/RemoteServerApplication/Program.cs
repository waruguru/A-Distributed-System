using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using PTSLibraryRecent;


namespace RemoteServerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel Channel = new HttpChannel(50000);
            ChannelServices.RegisterChannel(Channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PTSLibraryRecent.PTSAdminFacade), "PTSAdminFacade", WellKnownObjectMode.Singleton);
            Console.WriteLine("Press Enter Key To terminate Server");
            Console.ReadLine();
        }
    }
}
