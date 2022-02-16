﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using surchatAPI.DTO;
using surchatAPI.Hubs;
using System.Threading.Tasks;

namespace surchatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<ChatHub> hubContext;

        public ChatController(IHubContext<ChatHub> hubContext)
        {
            this.hubContext = hubContext;
        }
        [HttpPost]
        public async Task SendMessage(ChatMessage message)
        {
            //additional business logic 

            await this.hubContext.Clients.All.SendAsync("messageReceivedFromApi", message);

            //additional business logic 
        }
    }
}
    
