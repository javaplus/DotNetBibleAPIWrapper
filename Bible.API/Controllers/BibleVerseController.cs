using System;
using Bible.API.Models;
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
        public BibleVerse Get(){
            BibleVerse bibleVerse = new BibleVerse();
            bibleVerse.Book = "John";
            bibleVerse.Chapter = 3;
            bibleVerse.Verse = 16;
            bibleVerse.Text = "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish, but have everlasting life";
            return bibleVerse;
        }

    }
}