using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tarefas_00.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tarefas_00.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UserModel>> FindUsers()
        {
            Console.WriteLine("Hello World!");
            return Ok("teste");
        }

        [HttpGet]
        [Route("find_by_id")]
        public ActionResult<UserModel> GetUserById(int id)
        {
            return Ok("teste");
        }

        [HttpPost]
        public ActionResult<UserModel> CreateUser(UserModel user) 
        {
            return Ok();
        }

        [HttpPut]
        public ActionResult<UserModel> UpdateUser(UserModel user) 
        {
            return Ok();
        }

        [HttpDelete]
        public ActionResult<bool> DeleteUser(int ind)
        {
            return Ok();
        }
    }
}
