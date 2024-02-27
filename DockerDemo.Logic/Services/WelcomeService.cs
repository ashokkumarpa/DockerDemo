using DockerDemo.Data.IRepository;
using DockerDemo.Logic.IServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerDemo.Logic.Services
{
    public class WelcomeService : IWelcomeService
    {
        private readonly IWelcomeRepo _welcomeRepo;

        public WelcomeService(IWelcomeRepo welcomeRepo)
        {
            _welcomeRepo = welcomeRepo;
        }

        public async Task<string> GetWelcomeMessage(string name)
        {
            var welcomeMessage = await _welcomeRepo.GetWelcomeMessage();
            return $"Hello {name}!, {welcomeMessage}";
        }
    }
}
