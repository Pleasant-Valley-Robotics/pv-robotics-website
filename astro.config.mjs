import { defineConfig } from 'astro/config';

// Static site: `npm run build` writes plain HTML/CSS/images to dist/,
// which any web server (Caddy, Nginx) can serve as-is.
export default defineConfig({
  site: 'https://www.pvfirstrobotics.com',
  trailingSlash: 'ignore',
  build: { format: 'directory' },
  // Old Squarespace URLs that no longer have their own page.
  redirects: {
    '/home': '/',
    '/pv-toys': '/',
    '/cart': '/',
  },
});
