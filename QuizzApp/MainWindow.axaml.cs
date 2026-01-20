using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace QuizzApp;

public partial class MainWindow : Window
{

    private User user = new User();
    private Question question = new Question();

    public MainWindow()
    {
        InitializeComponent();
    }

    public void AuthHandler(object sender, RoutedEventArgs args)
    {
        Console.WriteLine("Should handle the auth");

        var name = NameTextBox.Text;
        var email = EmailTextBox.Text;

        if (!string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Config the user's name");
            user.Name = name;
            Message.Text = string.Empty;
        }


        if (!string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("Config the user's email");
            user.Email = email;
            Message.Text = string.Empty;
        }

        if (user.IsValid())
        {
            Console.WriteLine("The user is: " + user.Info());
            Message.Text = "You are authenticated!";
            Message.Background = Brushes.LightGreen;

            ShowQuestions();
        }
        else
        {
            Message.Text = "Please enter the needed credentials!";
            Message.Background = Brushes.Red;
        }

    }

    private void ShowQuestions()

    {
        AuthPanel.IsVisible = false;

        QuizzPanel.IsVisible = true; // Make the quizz panel visible
        QuestionsPanel.IsVisible = true; // Make the questions panel visible

    }

    private void FinishHandler(object sender, RoutedEventArgs args)
    {

        var correctAnswersCount = 0;

        var radioButtons = QuestionsPanel.Children
            .OfType<RadioButton>();
        string? currentQuestion = null;


        foreach (var btn in radioButtons)
        {
            if (btn.IsChecked == true && btn.Tag?.ToString() == "Correct")
                correctAnswersCount++;
        }

        if (correctAnswersCount == 3)
        {
            QuestionsPanel.IsVisible = false;
            CongratsMsg.Text = "You answered all question right! Congratulations!";
            InstructionBlock.Text = string.Empty;
            FailMsg.Text = string.Empty;
        }
        else
        {
            CongratsMsg.Text = string.Empty;
            FailMsg.Text = "Something is not right! Please review the answers";

        }

    }

}