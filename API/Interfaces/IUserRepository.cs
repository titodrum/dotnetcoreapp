using API.Entities;

namespace API.Interfaces;

public interface IUserRepository
{

    Task<bool> SaveAllAsync();
    Task<IEnumerable<AppUser>> GetUsersAsync();
    Task<AppUser?> GetUserByIdAsync(int id);
    Task<AppUser?> GetUserByUsernameAsync(string username);
    void Update(AppUser user);
}