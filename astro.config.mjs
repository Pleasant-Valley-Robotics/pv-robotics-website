import { defineConfig } from 'astro/config';

// Static site: `npm run build` writes plain HTML/CSS/images to dist/,
// which any web server (Caddy, Nginx) can serve as-is.
export default defineConfig({
  site: 'https://www.firstpvrobotics.com',
  trailingSlash: 'ignore',
  build: { format: 'directory' },
  // Old Squarespace URLs that no longer have their own page. Team pages moved to
  // each team's own site on the robotics server.
  redirects: {
    '/radical': 'https://7196.firstpvrobotics.com',
    '/deviation': 'https://6093.firstpvrobotics.com',
    '/prime-suspects': 'https://38350.firstpvrobotics.com',
    '/no-limits': 'https://9082.firstpvrobotics.com',
    '/home': '/',
    '/pv-toys': '/',
    '/cart': '/',
  },
});
