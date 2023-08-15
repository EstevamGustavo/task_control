using Microsoft.AspNetCore.Authorization;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Mvc;
using tarefas_00.Models;
using tarefas_00.Respository.Interfaces;

namespace tarefas_00.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
         public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> FindUsers()
        {
            List<UserModel> users = await _userRepository.FindUser();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> GetUserById(int id)
        {
            UserModel user = await _userRepository.FindById(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> AddUser([FromBody] UserModel userModel) 
        {
            UserModel user = await _userRepository.createUser(userModel);
           return Ok(user);
        }
        
        [HttpPut]
        public async Task<ActionResult<UserModel>> UpdateUser([FromBody] UserModel userModel, int id) 
        {
            userModel.Id = id;
            UserModel user = await _userRepository.UpdateUser(userModel, id);
            return Ok(user);
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteUser(int id)
        {
            bool deletedUser = await _userRepository.DeleteUser(id);
            return Ok(deletedUser);
        }
    }
}
