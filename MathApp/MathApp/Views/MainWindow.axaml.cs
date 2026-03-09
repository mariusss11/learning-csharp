// Views/MainWindow.axaml.cs
using Avalonia.Controls;
using MathApp.ViewModels;

namespace MathApp.Views;

public partial class MainWindow : Window
{
    private bool _allowClose = false;

    public MainWindow()
    {
        InitializeComponent();
    }

    protected override async void OnClosing(WindowClosingEventArgs e)
    {
        if (_allowClose)
        {
            base.OnClosing(e);
            return;
        }

        // Always cancel first
        e.Cancel = true;
        base.OnClosing(e);

        if (DataContext is MainWindowViewModel vm)
        {
            bool confirmed = await vm.ConfirmExit();
            if (confirmed)
            {
                _allowClose = true;
                Close();
            }
        }
    }
}