using System;
using Microsoft.AspNetCore.Components;

namespace BlazorTrainPlaying_Wasm.Client.Services
{
    /**
     * Use AppStateService instead of CascadingAppState when you need to be notified of changes
     */
    public class AppStateService
    {
        public string Message { get; private set; } = "";
        public bool Enabled { get; private set; } = false;
        public int Counter { get; private set; } = 0;

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