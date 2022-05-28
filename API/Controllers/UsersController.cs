using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase 
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() 
        {
            var users = await _context.Users.ToListAsync ();
            return users;
        }  //  GetUsers() 

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id) 
        {
            var user = await  _context.FindAsync<AppUser>(id );

            return user;
        }  //  GetUsers() 

        
    }  //  public class UsersController 
}  //  namespace API.Controllers 