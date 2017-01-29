using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Services
{
    public interface IViberSender
    {
        Task SendViberMessageAsync(string number, string message);
    }
}
