namespace PvRobotics.Web.Models;

public record Mentor(string Name, string Role)
{
    /// <summary>"Jason Franzenburg" becomes "JF", for the circle next to the name.</summary>
    public string Initials => string.Concat(Name.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(word => word[0]));
}

public record Sponsor(string Name, string Logo);

public record RoboticsProgram(string Code, string Name, string Description);

public record CoursePathway(string Name, List<string> Courses);

public record NavLink(string Label, string Href);

/// <summary>The big heading at the top of most pages. Used by Views/Shared/_PageHero.cshtml.</summary>
public record PageHero(string Eyebrow, string Title, string? Lede = null);

/// <summary>Everything the home page shows.</summary>
public class HomeViewModel
{
    public required List<Team> Teams { get; init; }
    public required List<Sponsor> Sponsors { get; init; }
    public int FtcTeamCount => Teams.Count(t => t.Program == "FTC");
    public int FrcTeamCount => Teams.Count(t => t.Program == "FRC");
}

/// <summary>Everything the About page shows.</summary>
public class AboutViewModel
{
    public required List<RoboticsProgram> Programs { get; init; }
    public required List<Team> Teams { get; init; }
    public required List<CoursePathway> Pathways { get; init; }
    public required List<Mentor> Mentors { get; init; }
}
