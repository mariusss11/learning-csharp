using System.Threading.Tasks;
using MathApp.ViewModels;

namespace MathApp.Services;

public interface IDialogService
{
    Task<TResult?> ShowDialog<TResult>(DialogViewModelBase<TResult> viewModel);
    void CloseDialog();
}