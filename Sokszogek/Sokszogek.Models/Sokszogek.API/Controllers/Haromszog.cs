using Microsoft.AspNetCore.Mvc;
using Sokszogek.Models;

namespace Sokszogek.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HaromszogController : ControllerBase
    {
        [HttpGet("Kerulet")]
        public double Kerulet(double oldalA, double oldalB, double oldalC)
        {
            var h = new Haromszog(oldalA, oldalB, oldalC);
            return h.Kerulet();
        }

        [HttpGet("Terulet")]
        public double Terulet(double oldalA, double oldalB, double oldalC)
        {
            var h = new Haromszog(oldalA, oldalB, oldalC);
            return h.Terulet();
        }
    }
}