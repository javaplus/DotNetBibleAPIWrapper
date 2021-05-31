using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bible.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibleVerseController:ControllerBase
    {
        private readonly ILogger<BibleVerseController> _logger;

        public BibleVerseController(ILogger<BibleVerseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get(){
            return "This is not a bible verse";
        }

    }
}