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
        
        public List<object> dashboard = new List<object>
        {
            new { shops = 300},
            new { wholesellers = 3000 },
            new { revenue = 600000 },
            new { customers = 200 }
           
        };


        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSuperAdminStats")]
        public List<object> GetSuperAdminStats()
        {

            return dashboard;
        }

        [HttpGet("{id}")]
        public object GetSuperAdminStats(int id)
        {
            return dashboard.ElementAt(id);
        }

        [HttpPost]
        public object PostSuperAdminStats(List<object> list)
        {
            dashboard.Add(list);
            return dashboard;
        }

    }
}
