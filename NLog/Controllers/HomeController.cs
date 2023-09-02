﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NLogLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }
        [HttpGet("[action]")]
        public IActionResult Get()
        {
            _logger.LogInformation("Hello, this is the Get!");

            return NoContent();
        }

        [HttpGet("[action]")]
        public IActionResult Erroor()
        {
            int x=0, y=0;
            try
            {
                int result = x / y;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,"Exception Bas");
                return BadRequest();
            }
           

            return NoContent();
        }
    }
}
