using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using crud_application.Services;

namespace crud_application.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    private readonly ILoginService _loginService;
    private readonly MainWindowViewModel _mainWindowVm;
    private readonly ICustomerService _customerService;
    
    [ObservableProperty] private string _errorMessage;
    [ObservableProperty] private string _username;
    [ObservableProperty] private string _password;
    
    public LoginViewModel(MainWindowViewModel mainWindowVm, ILoginService loginService, ICustomerService customerService)
    {
        _mainWindowVm = mainWindowVm;
        _loginService = loginService;
        _customerService = customerService;
    }
    
    [RelayCommand]
    private async Task Login()
    {
        var user = await _loginService.AuthenticateAsync(Username, Password);

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
}