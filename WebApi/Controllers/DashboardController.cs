using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System;
using WebApi.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {

        public static List<Dashboard> dashboard = new()
        {
            new Dashboard { shops = 300, wholesellers = 4500, revenue = 60000, customers = 100 }

};

        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSuperAdminStats")]
        public List<Dashboard> GetSuperAdminStats()
        {
            return dashboard;
        }

        [HttpGet("{id}")]
        public IActionResult GetSuperAdminStats(int id)
        {
            if (id < 0 || id >= dashboard.Count)
            {
                return NotFound(); // Or return an appropriate HTTP status code for invalid index
            }
            return Ok(dashboard[id]);
        }

        [HttpPost]
        public IActionResult PostSuperAdminStats([FromBody] Dashboard obj)
        {
            dashboard.Add(obj);
            return Ok(obj);
        }


        [HttpDelete("{id}")]
        public IActionResult DelSuperAdminStats(int id)
        {
            var current = dashboard.ElementAt(id);
            dashboard.Remove(current);
            return Ok(dashboard); 
        }
    }
}
