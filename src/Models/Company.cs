namespace Resume.Models;

public class Company
{
    public string ImageLink { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string ExternalLink { get; set; } = string.Empty;
    public string AltText => $"Logo for {CompanyName}";

    public IEnumerable<Experience> Experiences { get; set; } = [];
}