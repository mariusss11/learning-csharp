using MathApp.ViewModels;

namespace MathApp.Services;

// Services/DialogService.cs
using System.Threading.Tasks;

public class DialogService : IDialogService
{
    private readonly MainWindowViewModel _mainWindowViewModel;

    public DialogService(MainWindowViewModel mainWindowViewModel)
    {
        _mainWindowViewModel = mainWindowViewModel;
    }

    public Task<TResult?> ShowDialog<TResult>(DialogViewModelBase<TResult> viewModel)
    {
        _mainWindowViewModel.CurrentDialog = viewModel;
        _mainWindowViewModel.IsDialogOpen = true;
        return viewModel.ResultTask;
    }

    public void CloseDialog()
    {
        _mainWindowViewModel.IsDialogOpen = false;
        _mainWindowViewModel.CurrentDialog = null;
    }
}