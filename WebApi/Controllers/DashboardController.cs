using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private static readonly string[] Cust = new[]
        {
        "+200", "+250","+100","+400","+200"
    };


        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSuperAdminStats")]
        public IEnumerable<Shops> GetSuperAdminStats()
        {
            return Enumerable.Range(0,1).Select(index => new Shops
            {
                shops = Random.Shared.Next(10,300),
                wholesellers = Random.Shared.Next(50,4500),
                revenue = Random.Shared.Next(50000),
                customers = Random.Shared.Next(200)
            })
            .ToArray();
        }

        [HttpGet(Name = "GetSuperAdminStats")]
        public IEnumerable<Shops> GetSuperAdminStats()
        {
            return Enumerable.Range(0, 1).Select(index => new Shops
            {
                shops = Random.Shared.Next(10, 300),
                wholesellers = Random.Shared.Next(50, 4500),
                revenue = Random.Shared.Next(50000),
                customers = Random.Shared.Next(200)
            })
            .ToArray();
        }
    }
}
