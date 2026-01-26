using System;

public class User
{
    String name;
    String email;

    public string Name { get; set; }
    public string Email { get; set; }

    public bool IsValid() => !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Email);
    public string Info() => $"Name: {Name}, Email: {Email}";

}