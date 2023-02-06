using Microsoft.JSInterop;

namespace ReproRoslynError
{
    public class Component
    {
        private IJSObjectReference? _jsModule;

        protected async Task Repro()
        {
            _ = _jsModule?.InvokeVoidAsync("repro", "test");
        }
    }
}
