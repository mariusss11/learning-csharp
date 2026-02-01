using CommunityToolkit.Mvvm.ComponentModel;
using crud_application.Services;
using crud_application.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase _currentViewModel;

    private readonly ICustomerService _customerService;
    private readonly ILoginService _loginService;

    public MainWindowViewModel(ILoginService loginService, ICustomerService customerService)
    {
        _customerService = customerService;
        _loginService = loginService;

        // Start with login view
        CurrentViewModel = new LoginViewModel(this, _loginService, _customerService);
    }

    public void ShowDashboard()
    {
        CurrentViewModel = new DashboardViewModel(_customerService);
    }
}