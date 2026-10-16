using PvRobotics.Web.Data;

namespace PvRobotics.Web.Tests;

/// <summary>
/// Checks on Data/SiteContent.cs that catch typos before they reach the website.
/// </summary>
public class ContentTests
{
    // wwwroot/ of the website project, found from where the tests run.
    private static readonly string WwwRoot = Path.GetFullPath(Path.Combine(
        AppContext.BaseDirectory, "..", "..", "..", "..", "..", "src", "PvRobotics.Web", "wwwroot"));

    public static TheoryData<string> AllImages()
    {
        var images = new TheoryData<string>();
        foreach (var team in SiteContent.Teams) images.Add(team.Logo);
        foreach (var sponsor in SiteContent.Sponsors) images.Add(sponsor.Logo);
        return images;
    }

    [Theory]
    [MemberData(nameof(AllImages))]
    public void Every_image_file_exists(string imagePath)
    {
        var file = Path.Combine(WwwRoot, imagePath.TrimStart('/'));
        Assert.True(File.Exists(file), $"{imagePath} is listed in SiteContent.cs but there is no file at {file}");
    }

    [Fact]
    public void Team_numbers_are_unique()
    {
        var numbers = SiteContent.Teams.Select(t => t.Number).ToList();
        Assert.Equal(numbers.Count, numbers.Distinct().Count());
    }

    [Fact]
    public void Every_team_is_FTC_or_FRC()
    {
        Assert.All(SiteContent.Teams, team => Assert.Contains(team.Program, new[] { "FTC", "FRC" }));
    }
}
