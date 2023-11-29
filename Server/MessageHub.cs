using Microsoft.AspNetCore.SignalR;
using System.Numerics;

public class MessageHub : Hub
{
    public override async Task OnConnectedAsync()
    {
        Console.WriteLine(Clients.Caller.ToString());

        await Clients.Caller.SendAsync("ReceiveMessage", "Server");

        await base.OnConnectedAsync();
    }
}