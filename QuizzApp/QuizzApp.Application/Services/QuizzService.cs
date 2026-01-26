public class QuizService
{
    private readonly IQuizRepository _repo;

    public QuizService(IQuizRepository repo)
    {
        _repo = repo;
    }

    public async Task CreateAsync(CreateQuizDto dto)
    {
        var quiz = new Quiz { Title = dto.Title };
        await _repo.AddAsync(quiz);
    }
}
