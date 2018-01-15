using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;
using Microsoft.AspNet.SignalR;
using Service;

namespace web.Hubs
{
    public class GuestHub : Hub
    {

        public void Login(string username,string password)
        {
            User user = UserService.GetUser(username, password);
            Clients.Caller.loginResponse(user);
        }
    }
}