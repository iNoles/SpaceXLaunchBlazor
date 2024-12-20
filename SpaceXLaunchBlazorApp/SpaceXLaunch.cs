namespace SpaceXLaunchBlazorApp;

public class SpaceXLaunch
{
    public string? Next { get; set; }
    public object? Previous { get; set; }
    public List<Result>? Results { get; set; }
}

public class Result
{
    public string? Name { get; set; }
    public string? Location { get; set; }
    public DateTime? Net { get; set; }
    public Status? Status { get; set; }
}

public class Status
{
    public string? Abbrev { get; set; }
}