using System;
using MathApp.Services;

namespace MathApp.ViewModels;

// ViewModels/RectangleViewModel.cs
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class RectangleViewModel : DialogViewModelBase<bool>
{
    private readonly IDialogService _dialogService;

    [ObservableProperty] private string inputWidth = "";
    [ObservableProperty] private string inputHeight = "";
    [ObservableProperty] private string result = "";
    [ObservableProperty] private bool hasResult;

    public RectangleViewModel(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }

    [RelayCommand]
    private void Calculate()
    {
        if (!double.TryParse(InputWidth.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double w) ||
            !double.TryParse(InputHeight.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double h))
        {
            Result = "❌ Introduceți numere valide.";
            HasResult = true;
            return;
        }

        if (w <= 0 || h <= 0)
        {
            Result = "❌ Dimensiunile trebuie să fie pozitive.";
            HasResult = true;
            return;
        }

        double area = w * h;
        double perimeter = 2 * (w + h);
        string type = Math.Abs(w - h) < 1e-9 ? "Pătrat" : "Dreptunghi";

        Result = $"✅ Figura: {type}\nAria: {area:F4}\nPerimetrul: {perimeter:F4}";
        HasResult = true;
    }

    [RelayCommand]
    private void Close()
    {
        SetResult(true);
        _dialogService.CloseDialog();
    }
}