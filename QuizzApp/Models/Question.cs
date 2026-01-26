using System.Collections.Generic;

public class Question
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;

    // ✅ This must match the type you use in GetQuestions()
    public List<Option> Options { get; set; } = new();

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
                Options = new List<Option>
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
                Options = new List<Option>
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
