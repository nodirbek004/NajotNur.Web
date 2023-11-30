using Microsoft.AspNetCore.Mvc;
using NajotNur.Application.Interfaces;
using NajotNur.Domain.Entities;

namespace NajotNur.Web.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync(User user)
    {
        var result =await _userService.CreateAsync(user);
        return Ok(result);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateAsync(User user)
    {
        var result=await _userService.UpdateAsync(user);
        return Ok(result);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteAsync(int Id)
    {
        var result = await _userService.DeleteAsync(Id);
        return Ok(result);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAllAsync()
    {
        var result=await _userService.GetAllAsync();
        return Ok(result);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetByIdAsync(int Id)
    {
        var result =await _userService.GetByIdAsync(Id);
        return Ok(result);
    }

}
