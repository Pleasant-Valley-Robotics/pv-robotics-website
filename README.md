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
| A team's story, outreach, socials, email | `src/content/teams/<team>.md` |
| Mentors, sponsors, programs, class pathways, general email | `src/data/site.ts` |
| Navigation menu | `nav` in `src/data/site.ts` |
| Images (logos, photos) | `public/images/` |
| Colors and fonts | `src/styles/global.css` |

Each team file's name is its URL: `radical.md` is `/radical`. Adding a new `.md` file there creates a new team page automatically.

To add a sponsor, put the logo in `public/images/sponsors/` and add a line to `sponsors` in `src/data/site.ts`.
