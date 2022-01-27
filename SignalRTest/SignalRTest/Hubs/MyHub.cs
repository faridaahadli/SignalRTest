using Microsoft.AspNetCore.SignalR;

namespace SignalRTest.Hubs
{
    public class MyHub:Hub
    {
        public async void SendMessage(string message)
        {
            await Clients.All.SendAsync("message", message);
        }
    }
}
