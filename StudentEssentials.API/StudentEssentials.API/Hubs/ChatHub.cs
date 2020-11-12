using Microsoft.AspNetCore.SignalR;
using StudentEssentials.API.Models;
using StudentEssentials.API.Services;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {

        private readonly IStudentEssentialsRespository _studentEssentialsRepo;

        public ChatHub(IStudentEssentialsRespository studentEssentialsRepo)
        {
            _studentEssentialsRepo = studentEssentialsRepo ?? throw new ArgumentNullException(nameof(studentEssentialsRepo));
        }

        public async Task SendMessage(int groupId, MessageRequest messageRequest)
        {

            _studentEssentialsRepo.SendMessage(messageRequest);

            var messages =  _studentEssentialsRepo.GetMessages(groupId);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            JsonDocument jsonResult = JsonDocument.Parse(JsonSerializer.Serialize(messages, options));


            await Clients.All.SendAsync("ReceiveMessage", jsonResult);

        }
    }
}