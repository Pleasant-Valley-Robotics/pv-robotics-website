using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using PvRobotics.Web.Data;

namespace PvRobotics.Web.Tests;

/// <summary>
/// These tests start the whole website in memory and visit its pages, the way a
/// browser would. GitHub runs them on every pull request; if one fails, the pull
/// request can't be merged until it's fixed.
/// Run them yourself with:  dotnet test
/// </summary>
public class PageTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
{
    // A client that does NOT follow redirects, so we can check where they point.
    private readonly HttpClient _client = factory.CreateClient(new WebApplicationFactoryClientOptions { AllowAutoRedirect = false });

    [Theory]
    [InlineData("/", "PVHS")]
    [InlineData("/about", "What is Pleasant Valley FIRST?")]
    [InlineData("/sponsors", "Our sponsors")]
    [InlineData("/contact", "Let’s talk robots.")]
    [InlineData("/about/", "What is Pleasant Valley FIRST?")] // old links ended in a slash
    public async Task Page_loads_and_shows_its_heading(string address, string heading)
    {
        var response = await _client.GetAsync(address);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        // Razor writes some characters as HTML codes (’ becomes &#x2019;), so decode before comparing.
        var html = WebUtility.HtmlDecode(await response.Content.ReadAsStringAsync());
        Assert.Contains(heading, html);
    }

    [Fact]
    public async Task Home_page_shows_every_team()
    {
        var html = await _client.GetStringAsync("/");

        foreach (var team in SiteContent.Teams)
        {
            Assert.Contains(team.SiteUrl, html);
        }
    }

    [Fact]
    public async Task Missing_page_shows_the_404_page()
    {
        var response = await _client.GetAsync("/this-page-does-not-exist");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        Assert.Contains("drove off the field", await response.Content.ReadAsStringAsync());
    }

    [Fact]
    public async Task Health_check_answers()
    {
        var response = await _client.GetAsync("/healthz");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("Healthy", await response.Content.ReadAsStringAsync());
    }

    [Theory]
    [InlineData("/home", "/")]
    [InlineData("/pv-toys", "/")]
    [InlineData("/radical", "https://7196.firstpvrobotics.com/")]
    [InlineData("/deviation", "https://6093.firstpvrobotics.com/")]
    [InlineData("/prime-suspects", "https://38350.firstpvrobotics.com/")]
    [InlineData("/no-limits", "https://9082.firstpvrobotics.com/")]
    public async Task Old_addresses_redirect(string oldAddress, string newAddress)
    {
        var response = await _client.GetAsync(oldAddress);

        Assert.Equal(HttpStatusCode.MovedPermanently, response.StatusCode);
        Assert.Equal(newAddress, response.Headers.Location?.ToString());
    }
}
