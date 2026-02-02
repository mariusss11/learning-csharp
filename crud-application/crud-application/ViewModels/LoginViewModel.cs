using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using crud_application.Services;

namespace crud_application.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    
    private readonly MainWindowViewModel _mainWindow;
    private readonly IAuthService _authService;

    [ObservableProperty]
    private string _username;

    [ObservableProperty]
    private string _password;

    [ObservableProperty]
    private string _errorMessage;

    public LoginViewModel(MainWindowViewModel mainWindow, IAuthService authService)
    {
        _mainWindow = mainWindow;
        _authService = authService;
    }

    [RelayCommand]
    private async Task Login()
    {
        try
        {
            // Trim inputs
            await _authService.AuthenticateAsync(
                Username.Trim(), 
                Password
            );

            // Clear error if login successful
            ErrorMessage = string.Empty;

            // Navigate to dashboard or next page
            _mainWindow.ShowDashboard();
        }
        catch (InvalidOperationException ex)
        {
            // This catches your "User not found" or "Email already exists" errors
            ErrorMessage = "Invalid username or password.";
        }
        catch (Exception)
        {
            // Generic error for unexpected issues
            ErrorMessage = "An unexpected error occurred. Please try again.";
        }
    }

    [RelayCommand]
    private void ChangeToRegister()
    {
        _mainWindow.ShowRegister();
    }
}