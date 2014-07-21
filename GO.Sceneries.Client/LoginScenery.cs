using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GO.Core;

namespace GO.Sceneries.Client
{
    public class LoginScenery : Scenery
    {
        public override void Run()
        {

            Prompt("UserName");
            // do we have a username / password?
            Console.WriteLine("Username");
            UserName = Console.ReadLine();

            // attempt connect
            Application.Send(new LoginToExternalMessage(UserName, "password"));
            base.Run();
        }

        private string UserName { get; set; }
        private string Password { get; set; }


    }
}
