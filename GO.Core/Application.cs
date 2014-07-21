using GO.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GO.Core
{
    public class Application : 
        IHandle<LoadSceneryMessage>
    {
        public Application()
        {
        }

        public void Send(LoadSceneryMessage loadScenery)
        {
            Scenery = loadScenery.Scenery;
            Scenery.SetApplication(this);
        }

        private Scenery Scenery { get; set; }

        public void Run()
        {
            // keeps watching for input
            while (Scenery.GetMessage())
            {
            }
        }
    }
}
