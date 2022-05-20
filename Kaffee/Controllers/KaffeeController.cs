using Microsoft.AspNetCore.Mvc;

namespace Kaffee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeController : ControllerBase
    {

        private static List<Kaffeemaschine> kaffee = new()
        {
            new Kaffeemaschine()
            {
                wasser = 2,
                bohnen = 2
            }
        };

        private readonly ILogger<KaffeeController> _logger;

        public KaffeeController(ILogger<KaffeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetKaffee")]
        public bool GetKaffeemaschine()
        {
            Kaffeemaschine Kaffeemaschine = kaffee[0];

            return Kaffeemaschine.macheKaffee(0.5,0.5);            
        }
   }
}