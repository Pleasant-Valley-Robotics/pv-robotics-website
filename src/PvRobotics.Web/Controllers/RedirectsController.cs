using Microsoft.AspNetCore.Mvc;
using PvRobotics.Web.Data;

namespace PvRobotics.Web.Controllers;

/// <summary>
/// Addresses from the old Squarespace site, so old links and search results still work.
/// A "permanent" redirect (301) also tells search engines the page has moved for good.
/// </summary>
public class RedirectsController : Controller
{
    [Route("home")]
    [Route("pv-toys")]
    [Route("cart")]
    public IActionResult ToHomePage() => RedirectPermanent("/");

    [Route("radical")]
    public IActionResult Radical() => RedirectPermanent(TeamSite(7196));

    [Route("deviation")]
    public IActionResult Deviation() => RedirectPermanent(TeamSite(6093));

    [Route("prime-suspects")]
    public IActionResult PrimeSuspects() => RedirectPermanent(TeamSite(38350));

    [Route("no-limits")]
    public IActionResult NoLimits() => RedirectPermanent(TeamSite(9082));

    private static string TeamSite(int number) => SiteContent.Teams.Single(t => t.Number == number).SiteUrl;
}
