using System.Collections.Generic;
using System.Threading.Tasks;
using crud_application.Models;

namespace crud_application.Services;

public interface IAuthService
{
    Task<User> AuthenticateAsync(string username, string password);
    
    Task<User> RegisterUserAsync(string username, string fullName, string password);

    
    
    Task<User> GetUserByEmailAsync(string email);
}