using System;
using System.Threading.Tasks;
using crud_application.Data;
using crud_application.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_application.Services;

public class LoginService : ILoginService
{
    private readonly ApplicationDbContext _context;

    public LoginService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<User> AuthenticateAsync(string username, string password)
    {
        Console.WriteLine("Authenticating...");

        // Get the user by email asynchronously
        var user = await GetUserByEmailAsync(username);

        // Check if password matches
        // if (BCrypt.Net.BCrypt.EnhancedVerify(password, user.Password))
        // {
        //     return user; // authentication successful
        // }
        
        if (password == user.Password)
        {
            return user; // authentication successful
        }

        // authentication failed
        return null;
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
        var listAsync = await _context.Users.ToListAsync();

        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Email.Trim().ToLower() == email.Trim().ToLower());

        if (user == null)
            throw new InvalidOperationException($"User with email '{email}' not found.");

        return user;
    }
}