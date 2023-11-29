using Microsoft.AspNetCore.SignalR;

public class MessageHub : Hub
{
    public override async Task OnConnectedAsync()
    {
        Console.WriteLine(Clients.Caller.ToString());

        await Clients.Caller.SendAsync("ReceiveMessage", "Server");

        await base.OnConnectedAsync();
    }
}