namespace Resume.Models;

public class Experience
{
    public string Title { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public IEnumerable<string> Summary { get; set; } = [];
}