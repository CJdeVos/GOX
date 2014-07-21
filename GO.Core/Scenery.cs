using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GO.Core
{
    public abstract class Scenery
    {
        internal void SetApplication(Application app)
        {
            Application = app;
        }

        protected Application Application { get; private set; }

        public virtual void Setup()
        {
            
        }

        public virtual void Run()
        {

        }
    }
}
