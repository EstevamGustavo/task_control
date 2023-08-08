using tarefas_00.Models;

namespace tarefas_00.Respository.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskModel>> FindTasks();
        Task<TaskModel> findTaskById(int id);
        Task<TaskModel> createTask(TaskModel task);
        Task<TaskModel> updateTask(TaskModel task, int id);
        Task<bool> deleteTask(int id);

    }
}
