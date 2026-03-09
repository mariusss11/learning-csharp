namespace MathApp.ViewModels;

// ViewModels/DialogViewModelBase.cs
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;


// ViewModels/DialogViewModelBase.cs
using CommunityToolkit.Mvvm.ComponentModel;

public abstract partial class DialogViewModelBase<TResult> : ObservableObject
{
    private readonly TaskCompletionSource<TResult?> _tcs = new();
    public Task<TResult?> ResultTask => _tcs.Task;

    protected void SetResult(TResult? result) => _tcs.TrySetResult(result);
}