using Microsoft.AspNetCore.Mvc;

namespace PokemonCardsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        // 🔹 GET: /health → retorna status "Healthy"
        [HttpGet("/health")]
        public IActionResult GetHealth()
        {
            return Ok("Healthy");
        }
    }
}
