using PvRobotics.Web.Models;

namespace PvRobotics.Web.Data;

/// <summary>
/// All of the main site's words and lists. To change what the site says, edit this file.
/// Each team's full page lives in its own repository (team-website-&lt;number&gt;).
/// </summary>
public static class SiteContent
{
    public const string Name = "Pleasant Valley FIRST Robotics";
    public const string ShortName = "PV Robotics";
    public const string Tagline = "Solving problems. Impacting lives.";
    public const string School = "Pleasant Valley High School";
    public const string Location = "Bettendorf, Iowa";

    // TODO: a shared inbox for sponsors and prospective mentors. Until there is one,
    // general questions go to No Limit's inbox.
    public const string ContactEmail = "FRC9082@gmail.com";

    // The teams, in the order they appear on the site.
    public static readonly List<Team> Teams =
    [
        new Team
        {
            Name = "Everything That's Radical",
            ShortName = "Radical",
            Program = "FTC",
            Number = 7196,
            Tagline = "A FIRST Tech Challenge team at Pleasant Valley High School.",
            Logo = "/images/teams/radical-logo.png",
            AccentColor = "#f472b6",
            Socials =
            [
                new("Instagram", "https://www.instagram.com/team.radical7196"),
                new("Facebook", "https://www.facebook.com/7196.Everything.thats.radical"),
                new("TikTok", "https://www.tiktok.com/@team.radical7196"),
                new("X", "https://www.twitter.com/7196ETR"),
            ],
        },
        new Team
        {
            Name = "Deviation From the Norm",
            ShortName = "Deviation",
            Program = "FTC",
            Number = 6093,
            Tagline = "A FIRST Tech Challenge team at Pleasant Valley High School.",
            Logo = "/images/teams/deviation-logo.png",
            AccentColor = "#38bdf8",
            Email = "deviationftm6093@gmail.com",
            Socials =
            [
                new("Instagram", "https://www.instagram.com/deviationfromthenorm"),
                new("X", "https://www.twitter.com/DeviationFTM"),
            ],
        },
        new Team
        {
            Name = "Prime Suspects",
            ShortName = "Prime Suspects",
            Program = "FTC",
            Number = 38350,
            Tagline = "A FIRST Tech Challenge team at Pleasant Valley High School.",
            Logo = "/images/teams/prime-suspects-logo.jpg",
            LogoBackground = "#000000",
            AccentColor = "#3b82f6",
        },
        new Team
        {
            Name = "No Limit Robotics",
            ShortName = "No Limit",
            Program = "FRC",
            Number = 9082,
            Tagline = "A FIRST Robotics Competition team at Pleasant Valley High School.",
            Logo = "/images/teams/no-limit-logo.png",
            AccentColor = "#fbbf24",
            Email = "FRC9082@gmail.com",
            Socials =
            [
                new("Instagram", "https://www.instagram.com/frc_9082/"),
                new("TikTok", "https://www.tiktok.com/@frc.9082.no.limit"),
                new("X", "https://www.twitter.com/frc9082"),
            ],
        },
    ];

    // The menu at the top of every page. Team links go to each team's own site.
    public static List<NavLink> Nav =>
    [
        new("About", "/about"),
        .. Teams.Select(t => new NavLink(t.ShortName, t.SiteUrl)),
        new("Sponsors", "/sponsors"),
        new("Contact", "/contact"),
    ];

    public static readonly List<Mentor> Mentors =
    [
        new("Jason Franzenburg", "Coach"),
        new("Brandon Seamer", "Coach"),
        new("Greg Smith", "Coach"),
        new("Mason Hancock", "Engineering Mentor"),
        new("Mike Brand", "Engineering Mentor"),
        new("Andrew Meckley", "Business Mentor"),
        new("Richard Naylor", "Machinery Mentor"),
        new("Kane Greenwalt", "Media Mentor"),
        new("Angie Brand", "Media Mentor"),
        new("Ricky Naylor", "Mentor"),
    ];

    public static readonly List<Sponsor> Sponsors =
    [
        new("John Deere", "/images/sponsors/john-deere.png"),
        new("NASA", "/images/sponsors/nasa.png"),
        new("Gene Haas Foundation", "/images/sponsors/gene-haas-foundation.webp"),
        new("MidAmerican Energy", "/images/sponsors/midamerican-energy.png"),
        new("REV Robotics", "/images/sponsors/rev-robotics.webp"),
        new("Argosy Foundation", "/images/sponsors/argosy-foundation.png"),
        new("Scott County Regional Authority", "/images/sponsors/scott-county-regional-authority.jpg"),
        new("Scott County Community Foundation", "/images/sponsors/scott-county-community-foundation.png"),
        new("Pleasant Valley Community School District", "/images/sponsors/pleasant-valley-csd.png"),
    ];

    public static readonly List<RoboticsProgram> Programs =
    [
        new("FTC", "FIRST Tech Challenge",
            "Design, program and drive a robot in an alliance-style competition. Teams of up to fifteen PVCSD students in grades 9–12."),
        new("FRC", "FIRST Robotics Competition",
            "Everything FTC teaches, at industrial scale, plus fundraising, branding and large-team collaboration. Open to any number of PVCSD students in grades 9–12."),
    ];

    public static readonly List<CoursePathway> Pathways =
    [
        new("Engineering",
        [
            "Introduction to Engineering",
            "Robotics Engineering",
            "Principles of Engineering",
            "Civil Engineering and Architecture",
            "Engineering Problems",
            "Engineering Academy",
            "CAD 140 – Parametric Solid Modeling",
        ]),
        new("CNC Machining",
        [
            "Introduction to Manufacturing and Mechanics",
            "Advanced Manufacturing",
            "MFG 106 – Workplace Safety",
            "MFG 371 – Manual Projects",
            "MFG 192 – Blueprint Reading",
            "MFG 201 – CNC Training",
            "MFG 221 – CNC Milling Operator",
            "MFG 139 – Intro to CAD/CAM",
        ]),
        new("Welding",
        [
            "MFG 361 – VR Welding",
            "WEL 362 – Fundamentals of Welding",
            "WEL 363 – Welding Defects",
            "WEL 364 – GMAW",
            "WEL 365 – Flux Core and Metal Cutting",
            "WEL 366 – SMAW",
            "WEL 191 – GTAW",
            "WEL 367 – Advanced Welding Blueprint Reading",
        ]),
    ];
}
