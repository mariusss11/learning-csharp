using System;
using MathApp.Services;

namespace MathApp.ViewModels;


// ViewModels/TriangleViewModel.cs
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class TriangleViewModel : DialogViewModelBase<bool>
{
    private readonly IDialogService _dialogService;

    [ObservableProperty] private string inputA = "";
    [ObservableProperty] private string inputB = "";
    [ObservableProperty] private string inputC = "";
    [ObservableProperty] private string result = "";
    [ObservableProperty] private bool hasResult;

    public TriangleViewModel(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }

    [RelayCommand]
    private void Calculate()
    {
        if (!double.TryParse(InputA.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double a) ||
            !double.TryParse(InputB.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double b) ||
            !double.TryParse(InputC.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double c))
        {
            Result = "Introduceți numere valide pentru a, b, c.";
            HasResult = true;
            return;
        }

        if (a <= 0 || b <= 0 || c <= 0)
        {
            Result = "Laturile trebuie să fie pozitive.";
            HasResult = true;
            return;
        }

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Result = "Aceste valori nu pot forma un triunghi.\n(Suma a oricăror două laturi trebuie să fie mai mare decât a treia)";
            HasResult = true;
            return;
        }

        // Determine triangle type
        string nature;
        if (a == b && b == c)
            nature = "Echilateral (toate laturile egale)";
        else if (IsRightAngled(a, b, c))
            nature = "Dreptunghic (suma pătratelor a două laturi = pătratul celei de-a treia)";
        else if (a == b || b == c || a == c)
            nature = "Isoscel (două laturi egale)";
        else
            nature = "Oarecare / Scalent (toate laturile diferite)";

        double s = (a + b + c) / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        Result = $"Triunghi valid!\nTipul triunghiului: {nature}\nAria (Heron): {area:F4}";
        HasResult = true;
    }

    private static bool IsRightAngled(double a, double b, double c)
    {
        // Sort sides so c is the largest
        double[] sides = [a, b, c];
        Array.Sort(sides);
        double tolerance = 1e-9;
        return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < tolerance;
    }

    [RelayCommand]
    private void Close()
    {
        SetResult(true);
        _dialogService.CloseDialog();
    }
}