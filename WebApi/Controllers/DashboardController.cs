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
        public List<int> dashboard = new List<int>()
        {
            300,
            4500,
            50000,
            100
        };


        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSuperAdminStats")]
        public List<int> GetSuperAdminStats()
        {
            
            return dashboard;
        }

        [HttpGet("{id}")]
        public int GetSuperAdminStats(int id)
        {
            return dashboard.ElementAt(id);
        }

    }
}
