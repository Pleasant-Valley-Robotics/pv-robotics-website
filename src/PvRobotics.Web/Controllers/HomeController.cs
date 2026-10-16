using Microsoft.AspNetCore.Mvc;
using PvRobotics.Web.Data;
using PvRobotics.Web.Models;

namespace PvRobotics.Web.Controllers;

/// <summary>
/// The site's pages. Each action picks the data for one page and hands it to the
/// view with the same name in Views/Home/ (Index() uses Views/Home/Index.cshtml).
/// </summary>
public class HomeController : Controller
{
    [Route("")]
    public IActionResult Index()
    {
        var model = new HomeViewModel
        {
            Teams = SiteContent.Teams,
            Sponsors = SiteContent.Sponsors,
        };
        return View(model);
    }

    [Route("about")]
    public IActionResult About()
    {
        var model = new AboutViewModel
        {
            Programs = SiteContent.Programs,
            Teams = SiteContent.Teams,
            Pathways = SiteContent.Pathways,
            Mentors = SiteContent.Mentors,
        };
        return View(model);
    }

    [Route("sponsors")]
    public IActionResult Sponsors() => View(SiteContent.Sponsors);

    [Route("contact")]
    public IActionResult Contact() => View(SiteContent.Teams);
}
