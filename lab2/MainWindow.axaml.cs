using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;


namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Greet(object? sender, RoutedEventArgs e)
    {
        var name = NameTextBox.Text;
        var age = AgeTextBox.Text;
        if (!string.IsNullOrWhiteSpace(name))
        {
            TextBoxName.Text = $"Hello {name}!";
            TextBoxName.Background = Brushes.Transparent;
        }
        else
        {
            TextBoxName.Text = "Please enter your name";
            // TextBoxName.TextWrapping = TextWrapping.Wrap;
            TextBoxName.Background = Brushes.Red;
        }

        if (!string.IsNullOrWhiteSpace(age))
        {
            TextBoxAge.Text = $"You are {age} years old!";
            TextBoxAge.Background = Brushes.Transparent;
        }
        else
        {
            TextBoxAge.Text = "Please enter your age";
            // TextBoxAge.TextWrapping = TextWrapping.Wrap;
            TextBoxAge.Background = Brushes.Red;
        }


    }

    private async void Button2_Click(object? sender, RoutedEventArgs e)
    {
        var dialog = new Window
        {
            Width = 300,
            Height = 150,
            Content = new TextBlock
            {
                Text = "Ești sigur că dorești să închizi aplicația?",
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center
            }
        };

        await dialog.ShowDialog(this);
    }
}
