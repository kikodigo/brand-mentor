using Microsoft.AspNetCore.Mvc;
using SistemaEscolar.Domain;

namespace SistemaEscolar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Aluno")]
        public Aluno Get()
        {

            var bla = new Aluno("rodrigo", DateTime.Parse("1992-04-08"));
            return bla;
        }
    }
}