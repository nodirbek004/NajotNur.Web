
using NajotNur.Domain.Entities;

namespace NajotNur.Application.Interfaces;

public interface IUserService
{
    public ValueTask<User> CreateAsync(User  user);
    public ValueTask<User> UpdateAsync(User user);
    public ValueTask<bool> DeleteAsync(int Id);
    public ValueTask<IEnumerable<User>> GetAllAsync();
    public ValueTask<User> GetByIdAsync(int Id);
}
