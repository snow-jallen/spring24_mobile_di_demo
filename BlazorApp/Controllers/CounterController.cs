using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RazorClassLibrary1.Services;

namespace BlazorApp.Controllers
{
    [Route("api/mobile/[controller]")]
    [ApiController]
    public class CounterController(ICounterService counterService) : ControllerBase
    {
        [HttpGet]
        public async Task<int> GetCurrentValue() => await counterService.GetCurrentValue();
        [HttpGet("NextValue")]
        public async Task<int> IncrementCurrentValue() => await counterService.IncrementCurrentValue();
    }
}
