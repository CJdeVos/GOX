using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GO.Core;
using GO.Core.Messages;
using GO.Sceneries.Client;

namespace GO.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            app.Send(LoadSceneryMessage.GetLoadMessage<LoginScenery>());
            app.Run();
            Console.WriteLine("-- exit --");
            Console.ReadLine();
        }
    }
}
