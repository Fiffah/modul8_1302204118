using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace modul8_1302204118.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<string> Stars1 = new List<string>
        {
            "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"
        };
        private static List<string> Stars2 = new List<string>
        {
            "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"
        };
        private static List<string> Stars3 = new List<string>
        {
            "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"
        };

        private readonly ILogger<MovieController> _logger;

        List<Movies> movies2 = new List<Movies>();

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            movies2.Add(new Movies(" The Shawshank Redemption", "Frank Darabont", Stars1, "Two imprisoned men bond over a number of years"));
            movies2.Add(new Movies(" The Godfather", "Francis Ford Coppola", Stars2, "The aging patriarch of an organized crime dynasty"));
            movies2.Add(new Movies(" The Dark Knight", "Christopher Nolan", Stars3, "When the menace known as the Joker wreaks havoc an chaos"));


            return movies2.ToArray();
        }

        [HttpGet("{id}")]
        public Movies GetMoviesById(int id)
        {
            movies2.Add(new Movies(Movies.Title, Movies.Director, Movies.Stars, Movies.Description));
            return movies2;
        }

    }
}
