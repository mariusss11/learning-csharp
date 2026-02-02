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
        var user = await _authService.RegisterUserAsync(Username, FullName, Password);

        if (user != null)
        {
            Console.Write("Logging in...");
            _mainWindowVm.ShowDashboard();
        }
        else
        {
            Console.Write("Username or password is incorrect.");
        }
    }

    [RelayCommand]
    private void ChangeToLogin()
    {
        _mainWindowVm.ShowLogin();
    }
}