using Microsoft.AspNetCore.Mvc;
using tarefas_00.Models;

namespace tarefas_00.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {
        [HttpGet]
        public ActionResult<TaskModel> GetFindTasks()
        {
            return View();
        }

        [HttpGet]
        [Route("find_by_id")]
        public ActionResult<TaskModel> GetFindTaskById(int id) 
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<TaskModel> PostCreateTask(TaskModel task) 
        {
            return Ok();        
        }

        [HttpPut]
        public ActionResult<TaskModel> PutUpdateTask(TaskModel task) 
        {
            return Ok();
        }

        [HttpDelete]
        public ActionResult<bool> DeleteTask(int id) 
        {
            return Ok();
        }
    }
}
