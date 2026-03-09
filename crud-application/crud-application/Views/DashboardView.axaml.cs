using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using crud_application.ViewModels;

namespace crud_application.Views;

public partial class DashboardView : UserControl
{
    public DashboardView()
    {
        InitializeComponent();
    }
    
    public DashboardView(DashboardViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}