using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerDemo.Logic.IServices
{
    public interface IWelcomeService
    {
        Task<string> GetWelcomeMessage(string name);
    }
}
