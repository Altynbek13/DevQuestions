using DevQuestions.Domain.Questions;

namespace DevQuestions.Domain.Tags;

public class Tag
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    public List<Question> Questions { get; set; } = [];
}
