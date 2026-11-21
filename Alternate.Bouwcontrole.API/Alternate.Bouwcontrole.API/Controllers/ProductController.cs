using Alternate.Bouwcontrole.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alternate.Bouwcontrole.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private List<Moederbord> moederborden = new List<Moederbord>
        {
            new Moederbord { KrakenId = 100038250, Brand = "GIGABYTE", Name = "GIGABYTE B650 EAGLE AX", Socket = "AM5", Chipset = "B650", Formfactor = "ATX", InternalUSB = 4},
        }
    }
}
