
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _dbContext;
        public UsersController(DataContext datacontext)
        {
            _dbContext = datacontext;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){

           return await _dbContext.Users.ToListAsync();
            
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id){

            return await _dbContext.Users.FindAsync(id);
            
            
        }

    }
}