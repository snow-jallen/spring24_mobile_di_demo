using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorClassLibrary1.Services;

namespace TheReallyCoolOne.Services;

public class MobileCounterService : RazorClassLibrary1.Services.ICounterService
{
    HttpClient httpClient = new();

    public async Task<int> GetCurrentValue()
    {
        string result =  await httpClient.GetStringAsync("http://localhost:5292/api/mobile/counter");
        return int.Parse(result);
    }

    public async Task<int> IncrementCurrentValue()
    {
        string result = await httpClient.GetStringAsync("http://localhost:5292/api/mobile/counter/nextvalue");
        return int.Parse(result);
    }

}
