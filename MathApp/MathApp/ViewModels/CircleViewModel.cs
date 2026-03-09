using System;

namespace MathApp.ViewModels;

// ViewModels/CircleViewModel.cs
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MathApp.Services;


public partial class CircleViewModel : DialogViewModelBase<bool>
{
    private readonly IDialogService _dialogService;

    [ObservableProperty] private string inputRadius = "";
    [ObservableProperty] private string result = "";
    [ObservableProperty] private bool hasResult;

    public CircleViewModel(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }

    [RelayCommand]
    private void Calculate()
    {
        if (!double.TryParse(InputRadius.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double r))
        {
            Result = "❌ Introduceți un număr valid pentru rază.";
            HasResult = true;
            return;
        }

        if (r <= 0)
        {
            Result = "❌ Raza trebuie să fie pozitivă.";
            HasResult = true;
            return;
        }

        double area = Math.PI * r * r;
        double circumference = 2 * Math.PI * r;

        Result = $"✅ Cerc valid!\nAria: {area:F4}\nCircumferința: {circumference:F4}";
        HasResult = true;
    }

    [RelayCommand]
    private void Close()
    {
        SetResult(true);
        _dialogService.CloseDialog();
    }
}