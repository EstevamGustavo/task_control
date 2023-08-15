using Microsoft.EntityFrameworkCore;
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

        public async Task<TaskModel> findTaskById(int id)
        {
            return await _dbContext.Tasks.FirstOrDefaultAsync(row => row.Id == id);
        }

        public async Task<List<TaskModel>> FindTasks()
        {
            return await _dbContext.Tasks.ToListAsync();
        }

       
        public async Task<TaskModel> createTask(TaskModel task)
        {
            await _dbContext.Tasks.AddAsync(task);
            await _dbContext.SaveChangesAsync();
            return task;
        }                     

        public async Task<TaskModel> updateTask(TaskModel taskModel, int id)
        {
            TaskModel taskById = await _dbContext.Tasks.FirstOrDefaultAsync(row => row.Id == id);
            if(taskById == null)
            {
                throw new Exception("Task not found!!");
            }

            taskById.Name = taskModel.Name;
            taskById.Description = taskModel.Description;

            _dbContext.Tasks.Update(taskById);
            await _dbContext.SaveChangesAsync();

            return taskById;

        }
        public async Task<bool> deleteTask(int id)
        {
            TaskModel taskById = await _dbContext.Tasks.FirstOrDefaultAsync(row => row.Id == id);
            if (taskById == null)
            {
                throw new Exception("Task not found!!");
            }

           _dbContext.Tasks.Remove(taskById);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
