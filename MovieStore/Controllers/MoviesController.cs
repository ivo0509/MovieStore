using Microsoft.AspNetCore.Mvc;
using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Movie> Get()
        {
            return _movieService.GetAllMovies();
        }

        [HttpPost("Add")]
        public void Add(Movie movie)
        {
            _movieService.AddMovie(movie);
        }

    }
}
