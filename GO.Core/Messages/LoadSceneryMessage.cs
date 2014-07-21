using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GO.Core.Messages
{
    public class LoadSceneryMessage : Message
    {
        protected LoadSceneryMessage(Scenery scenery)
        {
            Scenery = scenery;
        }

        public Scenery Scenery { get; private set; }

        
        public static LoadSceneryMessage GetLoadMessage<T>() where T : Scenery, new()
        {
            return new LoadSceneryMessage(new T());
        }
    }
}
