namespace SpaceXLaunchBlazorApp;

public class SpaceXLaunch
{
    public string next { get; set; }
    public object previous { get; set; }
    public List<Result> results { get; set; }
}

public class Result
{
    public string name { get; set; }
    public string location { get; set; }
    public DateTime net { get; set; }
    public Status status { get; set; }
}

public class Status
{
    public string abbrev { get; set; }
}