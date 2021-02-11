using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorTrainPlaying_Wasm.Server.Hubs
{
    public class DataHub : Hub
    {
        public async Task SyncRecord(string table, string action, string id)
        {
            await Clients.Others.SendAsync("ReceiveSyncRecord", table, action, id);
        }
    }
}