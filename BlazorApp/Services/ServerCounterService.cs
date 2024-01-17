using RazorClassLibrary1.Services;

namespace BlazorApp.Services
{
    public class ServerCounterService : ICounterService
    {
        private int Count = 0;
        public Task<int> GetCurrentValue()
        {
            return Task.FromResult(Count);
        }

        public Task<int> IncrementCurrentValue()
        {
            return Task.FromResult(++Count);
        }
    }
}
