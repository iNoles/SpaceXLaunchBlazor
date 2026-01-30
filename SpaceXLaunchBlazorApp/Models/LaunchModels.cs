using System.Text.Json.Serialization;

namespace SpaceXLaunchBlazorApp.Models
{
    public sealed class LaunchResponse
    {
        [JsonPropertyName("results")]
        public List<Launch> Results { get; set; } = [];
    }

    public sealed class Launch
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("net")]
        public DateTimeOffset? Net { get; set; }

        [JsonPropertyName("status")]
        public LaunchStatus Status { get; set; } = new();

        [JsonPropertyName("launch_service_provider")]
        public LaunchServiceProvider? LaunchServiceProvider { get; set; }

        [JsonPropertyName("pad")]
        public Pad? Pad { get; set; }

        public Image? Image { get; set; }

        public Mission? Mission { get; set; }
    }

    public sealed class LaunchStatus
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    public sealed class LaunchServiceProvider
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    public sealed class Pad
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("location")]
        public Location? Location { get; set; }
    }

    public sealed class Location
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    public sealed class Mission
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public sealed class Image
    {
        [JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }
    }
}
