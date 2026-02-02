using CommunityToolkit.Mvvm.ComponentModel;
using crud_application.Services;
using crud_application.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase _currentViewModel;

    private readonly ICustomerService _customerService;
    private readonly IAuthService _authService;

    public MainWindowViewModel(IAuthService authService, ICustomerService customerService)
    {
        _customerService = customerService;
        _authService = authService;

        // Start with login view
        CurrentViewModel = new LoginViewModel(this, _authService, _customerService);
    }

    public void ShowDashboard()
    {
        CurrentViewModel = new DashboardViewModel(_customerService);
    }
    
    public void ShowLogin()
    {
        CurrentViewModel = new LoginViewModel(this, _authService, _customerService);
    }
    
    public void ShowRegister()
    {
        CurrentViewModel = new RegisterViewModel(this, _authService, _customerService);
    }
}