using System;
using Bible.API.Models;
using Bible.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bible.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibleVerseController:ControllerBase
    {
        private readonly ILogger<BibleVerseController> _logger;

        private BibleAPIService _service;

        public BibleVerseController(ILogger<BibleVerseController> logger)
        {
            _logger = logger;
            _service = new BibleAPIService();
        }

        [HttpGet]
        public BibleVerse Get(){
            BibleVerse bibleVerse = _service.getJohn316();
            
            return bibleVerse;
        }

    }
}