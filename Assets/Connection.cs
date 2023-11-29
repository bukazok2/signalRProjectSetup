using Microsoft.AspNetCore.SignalR.Client;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour
{
    public HubConnection hubConnection;

    private async void Start()
    {
        this.hubConnection = new HubConnectionBuilder()
         .WithUrl("http://localhost:5204/chatHub")
         .Build();
        await this.hubConnection.StartAsync();
    }
}
