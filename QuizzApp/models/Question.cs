using System;

public class Question
{
    public int Id { get; set; }
    public string Text { get; set; }
    public Option[] Options { get; set; } = Array.Empty<Option>();


    public int CorrectOption { get; set; } // index of the correct option

    // Method to return mock questions
    public static Question[] GetQuestions()
    {
        return new Question[]
        {
            new Question
            {
                Id = 1,
                Text = "What is the capital of France?",
                Options = new Option[]
                {
                    new Option { Text = "Paris" },
                    new Option { Text = "London" },
                    new Option { Text = "Berlin" },
                    new Option { Text = "Madrid" }
                },
                CorrectOption = 0
            },
            new Question
            {
                Id = 2,
                Text = "Which language is primarily used for web development?",
                Options = new Option[]
                {
                    new Option { Text = "C++" },
                    new Option { Text = "Python" },
                    new Option { Text = "JavaScript" },
                    new Option { Text = "Java" }
                },
                CorrectOption = 2
            }
        };
    }
}

