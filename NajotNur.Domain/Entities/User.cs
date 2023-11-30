using NajotNur.Domain.Commons;

namespace NajotNur.Domain.Entities;

public class User:AudiTable
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

}
