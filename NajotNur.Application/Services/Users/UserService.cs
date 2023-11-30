using Microsoft.EntityFrameworkCore;
using NajotNur.Application.Interfaces;
using NajotNur.Domain.Entities;
using NajotNur.Infrastructure.AppDbContext;

namespace NajotNur.Application.Services.Users;

public class UserService : IUserService
{
    private readonly AppDbContext _appDbContext;

    public UserService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async ValueTask<User> CreateAsync(User user)
    {
        await _appDbContext.Users.AddAsync(user);
        await _appDbContext.SaveChangesAsync();
        return user;
    }

    public async ValueTask<bool> DeleteAsync(int Id)
    {
        var result=await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == Id);
        if (result == null)
        {
            return false;
        } 
         _appDbContext.Users.Remove(result);
        await _appDbContext.SaveChangesAsync();
        return true;

    }

    public async ValueTask<IEnumerable<User>> GetAllAsync()
    {
        var result = await _appDbContext.Users.ToListAsync();
        return result;
    }

    public async ValueTask<User> GetByIdAsync(int Id)
    {
        return await _appDbContext.Users.FindAsync(Id);
    }

    public async ValueTask<User> UpdateAsync(User user)
    {
        var result = _appDbContext.Users.Update(user).Entity;
        await _appDbContext.SaveChangesAsync();
        return result;
    }
}
