using System;

public class User
{
    private String _name;
    private String _email;

    public string? Name { get; set; }
    public string? Email { get; set; }

    public bool IsValid() => !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Email);
    public string Info() => $"Name: {Name}, Email: {Email}";

}