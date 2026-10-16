# Pleasant Valley FIRST Robotics website

A static site built with [Astro](https://astro.build). `npm run build` turns it into plain HTML, CSS and images in `dist/`, and any web server can host that folder.

## Working on it

```bash
npm install        # first time only
npm run dev        # live preview at http://localhost:4321 while you edit
npm run build      # produce the final site in dist/
npm run preview    # serve the built dist/ folder locally
```

## Where to edit content

| What | File |
|------|------|
| A team's card (name, logo, tagline, socials, email) | `src/content/teams/<team>.md` |
| A team's own site (story, outreach, photos) | That team's repository: `Pleasant-Valley-Robotics/team-website-<number>` |
| Mentors, sponsors, programs, class pathways, general email | `src/data/site.ts` |
| Navigation menu | `nav` in `src/data/site.ts` |
| Images (logos, photos) | `public/images/` |
| Colors and fonts | `src/styles/global.css` |

Each team has its own site at `https://<number>.firstpvrobotics.com`, built from its own repository (start a new one from `Pleasant-Valley-Robotics/team-website-template`). Adding a `.md` file in `src/content/teams/` adds that team's card here; add it to `nav` in `src/data/site.ts` too.

To add a sponsor, put the logo in `public/images/sponsors/` and add a line to `sponsors` in `src/data/site.ts`.

## Releasing

Pushing to `main` builds the site onto the `release` branch (GitHub Actions). The robotics server then serves it after:

```bash
sudo robotics-release website release
```
