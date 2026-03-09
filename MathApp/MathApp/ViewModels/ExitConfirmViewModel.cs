using CommunityToolkit.Mvvm.Input;
using MathApp.Services;

namespace MathApp.ViewModels;

public partial class ExitConfirmViewModel : DialogViewModelBase<bool>
{
    private readonly IDialogService _dialogService;

    public ExitConfirmViewModel(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }

    [RelayCommand]
    private void Confirm()
    {
        SetResult(true);
        _dialogService.CloseDialog();
    }

    [RelayCommand]
    private void Cancel()
    {
        SetResult(false);
        _dialogService.CloseDialog();
    }
}