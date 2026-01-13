using Microsoft.AspNetCore.Mvc;
using Sokszogek.Models;

namespace Sokszogek.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeglalapController : ControllerBase
    {
        [HttpGet("Kerulet")]
        public double Kerulet(double oldalA, double oldalB)
        {
            var t = new Teglalap(oldalA, oldalB);
            return t.Kerulet();
        }

        [HttpGet("Terulet")]
        public double Terulet(double oldalA, double oldalB)
        {
            var t = new Teglalap(oldalA, oldalB);
            return t.Terulet();
        }
    }
}