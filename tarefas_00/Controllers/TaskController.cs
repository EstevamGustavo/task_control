using Microsoft.AspNetCore.Mvc;
using tarefas_00.Models;
using tarefas_00.Respository.Interfaces;

namespace tarefas_00.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {
        private readonly ITaskRepository _taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<TaskModel>>> GetFindTasks()
        {
            List<TaskModel> tasks = await _taskRepository.FindTasks();
            return Ok(tasks);
        }

        [HttpGet]
        [Route("find_by_id")]
        public async Task<ActionResult<TaskModel>> GetFindTaskById(int id) 
        {
            TaskModel task = await _taskRepository.findTaskById(id);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<TaskModel>> PostCreateTask([FromBody] TaskModel taskMpdel) 
        {
            TaskModel task = await _taskRepository.createTask(taskMpdel);
            return Ok();        
        }

        [HttpPut]
        public async Task<ActionResult<TaskModel>> PutUpdateTask(TaskModel taskModel, int id) 
        {
            taskModel.Id = id;
            TaskModel task = await _taskRepository.updateTask(taskModel, id);
            return Ok(task);
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteTask(int id) 
        {
            bool deletedTask = await _taskRepository.deleteTask(id);
            return Ok(deletedTask);
        }
    }
}
