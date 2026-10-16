namespace PvRobotics.Web.Models;

/// <summary>One robotics team, as shown on the home page cards and the contact page.</summary>
/// <remarks>Each team's full story lives on its own site, built from its own repository.</remarks>
public class Team
{
    public required string Name { get; init; }

    /// <summary>A short name for buttons and headings, like "Radical".</summary>
    public required string ShortName { get; init; }

    /// <summary>"FTC" or "FRC".</summary>
    public required string Program { get; init; }

    public required int Number { get; init; }

    public required string Tagline { get; init; }

    /// <summary>Path to the logo inside wwwroot, like "/images/teams/radical-logo.png".</summary>
    public required string Logo { get; init; }

    /// <summary>Color behind the logo. White suits most logos; use black for logos drawn on black.</summary>
    public string LogoBackground { get; init; } = "#ffffff";

    /// <summary>The team's color, used for borders and highlights.</summary>
    public required string AccentColor { get; init; }

    public string? Email { get; init; }

    public List<SocialLink> Socials { get; init; } = [];

    /// <summary>The team's own website on the robotics server.</summary>
    public string SiteUrl => $"https://{Number}.firstpvrobotics.com";
}

public record SocialLink(string Label, string Url);
