using NajotNur.Domain.Commons;

namespace NajotNur.Domain.Entities;

public class Admin:AudiTable
{
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}
