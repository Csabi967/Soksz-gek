using Microsoft.AspNetCore.Mvc;
using Sokszogek.Models;

namespace Sokszogek.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NegyzetController : ControllerBase
    {
        [HttpGet("Kerulet")]
        public double Kerulet(double oldalA)
        {
            var n = new Negyzet(oldalA);
            return n.Kerulet();
        }

        [HttpGet("Terulet")]
        public double Terulet(double oldalA)
        {
            var n = new Negyzet(oldalA);
            return n.Terulet();
        }
    }
}