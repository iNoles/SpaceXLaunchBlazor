namespace SpaceXLaunchBlazorApp;

public class SpaceXLaunchService(HttpClient httpClient)
{
    public async Task<List<Result>?> GetUpcomingLaunchesAsync()
    {
        var launch = await httpClient.GetFromJsonAsync<SpaceXLaunch>("https://ll.thespacedevs.com/2.2.0/launch/?format=json&mode=list&search=SpaceX");
        return launch?.results;
    }
}