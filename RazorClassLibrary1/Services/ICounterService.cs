using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1.Services
{
    public interface ICounterService
    {
        Task<int> GetCurrentValue();
        Task<int> IncrementCurrentValue();
    }
}
