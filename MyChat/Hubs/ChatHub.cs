using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MyChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message, string currentdatetime)
        {
            currentdatetime = DateTime.Now.ToString();
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message,currentdatetime);
        }
    }
}