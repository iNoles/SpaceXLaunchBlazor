using SpaceXLaunchBlazorApp.Models;

namespace SpaceXLaunchBlazorApp.Services
{
    public sealed class LaunchLibraryService(HttpClient http)
    {
        private readonly HttpClient _http = http;

        public async Task<List<Launch>> GetUpcomingSpaceXLaunchesAsync(
            CancellationToken cancellationToken = default)
        {
            const string endpoint =
                "launches/upcoming?format=json&search=SpaceX&ordering=net&limit=10";

            LaunchResponse? response = await _http.GetFromJsonAsync<LaunchResponse>(
                endpoint,
                cancellationToken);

            return response?.Results ?? [];
        }
    }
}
