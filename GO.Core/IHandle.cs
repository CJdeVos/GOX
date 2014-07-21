using System.Net.Mail;
using GO.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GO.Core
{
    public interface IHandle<T> where T: Message
    {
        void Send(T message);
    }
}
