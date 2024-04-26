using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Cinema.Model;

namespace Cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(policyName: "CorsPolicy")]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            List<Movie> Movies = new List<Movie>();
            Movies.Add(new Movie());
            return Movies;
        }
    }
}
