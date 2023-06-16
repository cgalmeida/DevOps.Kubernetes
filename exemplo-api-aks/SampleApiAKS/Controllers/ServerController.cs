using Microsoft.AspNetCore.Mvc;

namespace SampleApiAKS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ServerController> _logger;

        public ServerController(ILogger<ServerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return String.Format("Nome da Máquina: {0} \t Sistema Operacional: {1}", 
                Environment.MachineName, Environment.OSVersion.VersionString);
        }
    }
}