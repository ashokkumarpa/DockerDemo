using DockerDemo.Data.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerDemo.Data.Repository
{
    public class WelcomeRepo : IWelcomeRepo
    {
        public async Task<string> GetWelcomeMessage()
        {
            return "Welcome to docker demo app. Thanks for visit our site.";
        }
    }
}
