using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MontenegroRent.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("Info")]
        public async Task<string> Get()
        {
            return $"MontenegroRent.WebApi is running {DateTime.UtcNow}";
        }
    }
}
