# Pleasant Valley FIRST Robotics website

The main site at **https://www.firstpvrobotics.com**, written in C# with
ASP.NET Core MVC (.NET 10). Each team's own site lives in its own repository,
`Pleasant-Valley-Robotics/team-website-<number>`, and is linked from here.

## Run it on your computer

Install the [.NET 10 SDK](https://dotnet.microsoft.com/download), then:

```bash
dotnet run --project src/PvRobotics.Web     # opens http://localhost:5254
dotnet test                                  # runs the tests
```

`dotnet watch --project src/PvRobotics.Web` reloads the page each time you save.

## How it's put together (MVC)

| Folder | What's in it |
|---|---|
| `src/PvRobotics.Web/Program.cs` | Where the site starts: what it uses and what happens to each request |
| `Models/` | The shapes of the data: a `Team`, a `Sponsor`, a `Mentor` |
| `Data/SiteContent.cs` | **The words and lists the site shows.** Most edits happen here |
| `Controllers/` | One method per page. Each picks its data and hands it to a view. The `[Route("about")]` above a method is that page's address |
| `Views/Home/` | The HTML for each page (Razor: HTML plus `@` for C#) |
| `Views/Shared/` | `_Layout.cshtml` is the frame around every page; the files starting with `_` are reusable pieces |
| `wwwroot/` | Files sent as-is: `css/site.css`, `images/`, `fonts/` |
| `tests/PvRobotics.Web.Tests/` | Tests that visit every page and check the data. GitHub runs them on every pull request |

## Common changes

| Change | Where |
|---|---|
| Add or change a sponsor | Put the logo in `wwwroot/images/sponsors/`, add a line to `Sponsors` in `SiteContent.cs` |
| Add a mentor | `Mentors` in `SiteContent.cs` |
| Add a team | `Teams` in `SiteContent.cs` (and a logo in `wwwroot/images/teams/`). The team's own site comes from `team-website-template` |
| Add a page | A method in `HomeController.cs` with `[Route("new-page")]`, a view `Views/Home/NewPage.cshtml`, and a link in `Nav` in `SiteContent.cs` |
| Colors and fonts | The top of `wwwroot/css/site.css` |

## How it gets to the server

1. Open a pull request. GitHub builds the site, runs the tests and starts the container.
2. Merge it into `main`.
3. A mentor releases it on the robotics server:

   ```bash
   sudo robotics-release website
   ```

   The server pulls `main`, builds the container, and switches visitors to it only
   if `/healthz` answers. Otherwise the previous version keeps running.
   `sudo robotics-release website --back` puts the previous version back.

The files the server uses: `Dockerfile` (build and run the site), `compose.yaml`
(run it on port 18080), and `/srv/live/website/site.conf` on the server.
