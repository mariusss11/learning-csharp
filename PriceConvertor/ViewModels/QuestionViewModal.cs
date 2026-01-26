public class QuestionViewModel
{
    public int Id { get; set; }  // optional, for grouping RadioButtons
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public string CorrectOption { get; set; }
}
