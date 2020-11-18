using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Blazing Orchard",
    Author = ManifestConstants.OrchardCoreTeam,
    Website = ManifestConstants.OrchardCoreWebsite,
    Version = ManifestConstants.OrchardCoreVersion,
    Description = "Provides API endpoints to Blazor applications using the Blazing Orchard client-side framework.",
    Category = "Blazor",
    Dependencies = new[] { "OrchardCore.Contents" }
)]