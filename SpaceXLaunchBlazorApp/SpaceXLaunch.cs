using Microsoft.AspNetCore.Components.Routing;

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
    public DateTime? Net { get; set; }
    public Status? Status { get; set; }
    public Pad? Pad { get; set; }
}

public class Status
{
    public string? Name { get; set; }
}

public class Pad {
    public Location? Location { get; set; }
}

public class Location {
    public string? Name { get; set; }
}