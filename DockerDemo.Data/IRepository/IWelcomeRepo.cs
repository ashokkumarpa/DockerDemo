using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerDemo.Data.IRepository
{
    public interface IWelcomeRepo
    {
        Task<string> GetWelcomeMessage();
    }
}
