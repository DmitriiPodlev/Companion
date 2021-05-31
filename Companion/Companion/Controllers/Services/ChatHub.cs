using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Companion.Models.Entities;
using Microsoft.AspNetCore.SignalR;

namespace Companion.Controllers.Services
{
    public class ChatHub : Hub
    {
        public async Task Send(Message message)
        {
            await Clients.All.SendAsync("receiveMessage", message);
        }
    }
}
