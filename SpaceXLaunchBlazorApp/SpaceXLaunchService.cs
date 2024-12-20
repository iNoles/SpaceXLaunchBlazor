namespace SpaceXLaunchBlazorApp;

public class SpaceXLaunchService(HttpClient httpClient)
{
    public async Task<List<Result>?> GetUpcomingLaunchesAsync()
    {
        var launch = await httpClient.GetFromJsonAsync<SpaceXLaunch>("https://ll.thespacedevs.com/2.3.0/launches/?format=json&search=SpaceX");
        return launch?.Results;
    }
}