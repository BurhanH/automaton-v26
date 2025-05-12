namespace AutomationV26;

public record PostResponse
{
    public required int userId { get; init; }
    public required int id { get; init; }
    public required string title { get; init; }
    public required string body { get; init; }
}