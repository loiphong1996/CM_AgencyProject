using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace web.Hubs
{
    public class ChatHub : Hub
    {

        public void Hello()
        {
            Clients.All.helloResponse("Hello");
        }

        public void Message(string message)
        {
            Clients.OthersInGroup("chatGroup").message(message);
        }
    }
}