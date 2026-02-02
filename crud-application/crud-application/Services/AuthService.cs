using System;
using System.Threading.Tasks;
using crud_application.Data;
using crud_application.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_application.Services;

public class AuthService : IAuthService
{
    private readonly ApplicationDbContext _context;

    public AuthService(ApplicationDbContext context)
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
        
        if (BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            return user; // authentication successful
        } 
        return null;
    }

    public async Task<User> RegisterUserAsync(string username, string fullName, string password)
    {
        // Check if the email is valid 
        IsEmailValid(username);

        // Create the new user
        String hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, 12);
        
        var newUser = _context.Users.Add(new User
        {
            Email = username.Trim(),
            FullName = fullName.Trim(),
            Password = hashedPassword
        });

        // Add the user to the database
        await _context.SaveChangesAsync();

        return newUser.Entity;
    }
    

    public async Task<User> GetUserByEmailAsync(string email)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Email.Trim().ToLower() == email.Trim().ToLower());

        if (user == null)
            throw new InvalidOperationException($"User with email '{email}' not found.");

        return user;
    }
    
    public async void IsEmailValid(string email)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Email.Trim().ToLower() == email.Trim().ToLower());

        if (user != null) 
            throw new InvalidOperationException($"User with email '{email}' already exists.");
    }

}