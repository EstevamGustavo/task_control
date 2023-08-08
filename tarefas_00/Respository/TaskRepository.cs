using tarefas_00.Data;
using tarefas_00.Models;
using tarefas_00.Respository.Interfaces;

namespace tarefas_00.Respository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskDbContext _dbContext;
        public TaskRepository(TaskDbContext taskDbContext)
        {
            _dbContext = taskDbContext;
        }
        public Task<TaskModel> createTask(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public Task<bool> deleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskModel> findTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TaskModel>> FindTasks()
        {
            throw new NotImplementedException();
        }

        public Task<TaskModel> updateTask(TaskModel task, int id)
        {
            throw new NotImplementedException();
        }
    }
}
