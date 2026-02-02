using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using crud_application.Services;

namespace crud_application.ViewModels;

public partial class RegisterViewModel : ViewModelBase
{
    
    private readonly IAuthService _authService;
    private readonly MainWindowViewModel _mainWindowVm;
    private readonly ICustomerService _customerService;

    
    [ObservableProperty] private string _errorMessage;
    [ObservableProperty] private string _username;
    [ObservableProperty] private string _fullName;
    [ObservableProperty] private string _password;

    
    public RegisterViewModel(MainWindowViewModel mainWindowVm, IAuthService authService, ICustomerService customerService)
    {
        _mainWindowVm = mainWindowVm;
        _authService = authService;
        _customerService = customerService;
    }
    
    [RelayCommand]
    private async Task Register()
    {
        try
        {
            var user = await _authService.RegisterUserAsync(
                Username.Trim(), FullName.Trim(), Password
            );

            ErrorMessage = string.Empty;

            _mainWindowVm.ShowDashboard();
        }
        catch (InvalidOperationException ex)
        {
            ErrorMessage = "Invalid username or password";
        }
        catch (Exception)
        {
            // Generic error for unexpected issues
            ErrorMessage = "An unexpected error occurred. Please try again.";
        }
    }

    [RelayCommand]
    private void ChangeToLogin()
    {
        _mainWindowVm.ShowLogin();
    }
}