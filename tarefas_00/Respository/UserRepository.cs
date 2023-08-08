using Microsoft.EntityFrameworkCore;
using tarefas_00.Data;
using tarefas_00.Models;
using tarefas_00.Respository.Interfaces;

namespace tarefas_00.Respository
{
    public class UserRepository : IUserRepository
    {
        private readonly TaskDbContext _dbContext;
        public UserRepository(TaskDbContext taskDbContext) 
        {
            _dbContext = taskDbContext;
        }

        public async Task<UserModel> FindById(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(row => row.Id == id);
        }

        public async Task<List<UserModel>> FindUser()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<UserModel> createUser(UserModel user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;

        }
        public async Task<UserModel> UpdateUser(UserModel user, int id)
        {
            UserModel userById = await FindById(id);
            if(userById == null)
            {
                throw new Exception("User not found!!");
            }

            userById.Name = user.Name;
            userById.Email = user.Email;

            _dbContext.Users.Update(userById);
            await _dbContext.SaveChangesAsync();

            return userById;

        }

        public async Task<bool> DeleteUser(int id)
        {
            UserModel userById = await FindById(id);
            if (userById == null)
            {
                throw new Exception("User not found!!");
            }

            _dbContext.Users.Remove(userById);
            await _dbContext.SaveChangesAsync();

            return true;

        }      

    }
}
