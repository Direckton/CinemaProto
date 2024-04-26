using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cinema.Model;
using Microsoft.AspNetCore.Cors;

namespace Cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(policyName: "CorsPolicy")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User());
            return users;
        }
    }
}
