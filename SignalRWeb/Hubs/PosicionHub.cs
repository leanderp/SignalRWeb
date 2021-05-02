using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWeb.Hubs
{
    public class PosicionHub: Hub
    {
        public async Task EnviarPosicion(int lelf, int top)
        {
            await Clients.Others.SendAsync("RecibirPosicion", lelf, top);
        }
    }
}
