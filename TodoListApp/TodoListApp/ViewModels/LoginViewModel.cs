using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TodoListApp.ViewModels;

public partial class LoginViewModel : ObservableValidator
{
    
    [ObservableProperty] 
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Username is required")]
    private string _username;
    
    [ObservableProperty] 
    [NotifyDataErrorInfo]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
    [Required(ErrorMessage = "Password is required")]
    private string _password;

    [RelayCommand(CanExecute = nameof(CanLogin))]
    private void Login()
    {
        Debug.WriteLine($"Logged in as {Username}");
    }

    private bool CanLogin() => !HasErrors && !string.IsNullOrWhiteSpace(_username) && !string.IsNullOrWhiteSpace(_password);

    partial void OnUsernameChanged(string? value)
    {
        LoginCommand.NotifyCanExecuteChanged();
    }

}