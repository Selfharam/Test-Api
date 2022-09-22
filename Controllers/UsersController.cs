using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class usersController : ControllerBase
    {
      
        private readonly UserDataContext context;

        public usersController(UserDataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            var users = this.context.users;
            return users;
        }

        [HttpGet("{id}")]
        public List<User> GetById(int id)
        {
            var users = this.context.users.Where(p => p.id==id).ToList();
            return users;
        }
        
        [HttpPost]
        public void Post([FromBody] User user)
        {
            context.users.Add(user);
            context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user_update)
        {
            var user = this.context.users.Where(p => p.id == id).FirstOrDefault();

            user.name = user_update.name;
            user.family = user_update.family;
            user.date_birth = user_update.date_birth;

            context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var user = this.context.users.Where(p => p.id == id).FirstOrDefault();
            context.users.Remove(user);
            context.SaveChanges();
        }
    }
}