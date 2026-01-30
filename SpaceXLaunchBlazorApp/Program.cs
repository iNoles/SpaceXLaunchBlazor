using SpaceXLaunchBlazorApp.Components;
using SpaceXLaunchBlazorApp.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Razor Components + Blazor Server
builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

// HttpClient for Launch Library API
builder.Services.AddHttpClient<LaunchLibraryService>(client =>
{
    client.BaseAddress = new Uri("https://ll.thespacedevs.com/2.3.0/");
});

// Optional but recommended
builder.Services.AddResponseCompression();

WebApplication app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    _ = app.UseExceptionHandler("/Error", createScopeForErrors: true);
    _ = app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseResponseCompression();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
