using tarefas_00.Models;

namespace tarefas_00.Respository.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> FindUser();
        Task<UserModel> FindById(int id);
        Task<UserModel> createUser(UserModel user);
        Task<UserModel> UpdateUser(UserModel user, int id);
        Task<bool> DeleteUser(int id);
    }
}
