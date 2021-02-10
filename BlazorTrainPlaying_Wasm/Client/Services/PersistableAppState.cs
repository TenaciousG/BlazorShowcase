using System;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BlazorTrainPlaying_Wasm.Client.Services
{
    public class PersistableAppState
    {
        /*
         * Might not need JsonProperty on net5 because should support private setters
         */
        [JsonProperty]
        public string Message { get; private set; } = "";
        [JsonProperty]
        public bool Enabled { get; private set; } = false;
        [JsonProperty]
        public int Counter { get; private set; } = 0;
        [JsonProperty]
        public int TimeToLiveInSeconds { get; set; } = 60;
        [JsonProperty]
        public DateTime LastAccessed { get; set; } = DateTime.Now;

        public void UpdateMessage(ComponentBase source, string message)
        {
            Message = message;
            NotifyStateChanged(source, nameof(Message));
        }

        public void UpdateEnabled(ComponentBase source, bool enabled)
        {
            Enabled = enabled;
            NotifyStateChanged(source, nameof(Enabled));
        }

        public void UpdateCounter(ComponentBase source, int counter)
        {
            Counter = counter;
            NotifyStateChanged(source, nameof(Counter));
        }

        //Include ComponentBase to keep track of who raised the event, so that component doesnt need to handle its own events
        public event Action<ComponentBase, string> StateChanged;

        private void NotifyStateChanged(ComponentBase source, string property) =>
            StateChanged?.Invoke(source, property);
    }
}