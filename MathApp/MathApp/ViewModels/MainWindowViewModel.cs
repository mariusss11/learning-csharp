// ViewModels/MainWindowViewModel.cs

using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MathApp.Services;

namespace MathApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly IDialogService _dialogService;

    [ObservableProperty] private bool isDialogOpen;
    [ObservableProperty] private object? currentDialog;
    [ObservableProperty] private bool isMainWindowMaximized;

    public MainWindowViewModel()
    {
        _dialogService = new DialogService(this);
    }

    [RelayCommand]
    private async Task OpenTriangle()
    {
        var vm = new TriangleViewModel(_dialogService);
        await _dialogService.ShowDialog(vm);
    }

    [RelayCommand]
    private async Task OpenRectangle()
    {
        var vm = new RectangleViewModel(_dialogService);
        await _dialogService.ShowDialog(vm);
    }

    [RelayCommand]
    private async Task OpenCircle()
    {
        var vm = new CircleViewModel(_dialogService);
        await _dialogService.ShowDialog(vm);
    }

    // Called from MainWindow.axaml.cs on window close request
    public async Task<bool> ConfirmExit()
    {
        var vm = new ExitConfirmViewModel(_dialogService);
        bool? result = await _dialogService.ShowDialog(vm);
        return result == true;
    }
}