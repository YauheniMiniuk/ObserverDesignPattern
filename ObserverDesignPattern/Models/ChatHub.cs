using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ObserverDesignPattern.Models
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string name, string date)
        {
            await this.Clients.All.SendAsync("Send", message, name, date);
        }
    }
}
