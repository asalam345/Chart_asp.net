using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoChat.Models;
using Microsoft.AspNetCore.SignalR;
namespace DemoChat
{
    public class Class : Hub // "Hub" is abstract class  under Microsoft.AspNetCore.SignalR namespace
    {
        static List<Users> SignalRUsers = new List<Users>();
        private readonly static ConnectionMapping<string> _connections =  new ConnectionMapping<string>();
        public async Task SendMessage(string message, string userId)
        {
            var item = SignalRUsers.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
            await Clients.Clients(userId).SendAsync("ReceiveMessage", message, item);
            await Clients.Clients(Context.ConnectionId).SendAsync("OwnMessage", message.Trim());
        }

        public override async Task OnConnectedAsync()
        {
            var httpContext = Context.GetHttpContext();
            var name = httpContext.Request.Query["name"];

            _connections.Add(name, Context.ConnectionId);
            SignalRUsers.Add(new Users { UserName = name, ConnectionId = Context.ConnectionId });
            await Clients.All.SendAsync("UpdateUserList", _connections.ToJson());
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            var httpContext = Context.GetHttpContext();
            var name = httpContext.Request.Query["name"];

            _connections.Remove(name, Context.ConnectionId);
            var found = SignalRUsers.Where(w => w.ConnectionId == Context.ConnectionId).FirstOrDefault();
            if (found != null) SignalRUsers.Remove(found);
            return base.OnDisconnectedAsync(exception);
        }
        //public override Task OnConnectedAsync()
        //{
        //    var connectionId = Context.ConnectionId;
        //    //var id = Context.ConnectionId;

        //    if (SignalRUsers.Count(x => x.ConnectionId == connectionId) == 0)
        //    {
        //        SignalRUsers.Add(new Users { ConnectionId = connectionId });
        //    }
        //    Clients.All.SendAsync("OnlineUserList", SignalRUsers);
        //    return base.OnConnectedAsync();
        //}
        public async Task OnlineUsers()
        {
            var connectionId = Context.ConnectionId;
            await Clients.All.SendAsync("OnlineUserList", SignalRUsers);
        }
        public void Connect(string userName)
        {
            var id = Context.ConnectionId;

            if (SignalRUsers.Count(x => x.ConnectionId == id) == 0)
            {
                SignalRUsers.Add(new Users { ConnectionId = id, UserName = userName });
            }
        }

        //public override System.Threading.Tasks.Task OnDisconnectedAsync(Exception ex)
        //{
        //    var item = SignalRUsers.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
        //    if (item != null)
        //    {
        //        SignalRUsers.Remove(item);
        //    }

        //    return base.OnDisconnectedAsync(ex);
        //}
        //public override async Task OnDisconnectedAsync(Exception ex)
        //{
        //    await Clients.All.SendAsync("UserDisConnected", Context.ConnectionId);
        //    await base.OnDisconnectedAsync(ex);
        //}
    }
}