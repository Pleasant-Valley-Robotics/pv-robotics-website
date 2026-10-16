import { defineCollection, z } from 'astro:content';
import { glob } from 'astro/loaders';

// Each team is one Markdown file in src/content/teams/: just what the main site's cards
// and contact page need. Each team's full site lives in its own repository
// (Pleasant-Valley-Robotics/team-website-<number>) at https://<number>.firstpvrobotics.com.
const teams = defineCollection({
  loader: glob({ pattern: '*.md', base: './src/content/teams' }),
  schema: z.object({
    name: z.string(),
    shortName: z.string(),
    program: z.enum(['FTC', 'FRC']),
    number: z.number(),
    founded: z.string().optional(),
    tagline: z.string(),
    logo: z.string(),
    // Background behind the logo: white suits most logos; use a dark color for logos drawn on black.
    logoBg: z.string().default('#ffffff'),
    photo: z.string().optional(),
    photoAlt: z.string().optional(),
    accent: z.string(),
    order: z.number(),
    email: z.string().optional(),
    socials: z
      .array(z.object({ label: z.string(), url: z.string().url() }))
      .default([]),
    highlights: z.array(z.string()).default([]),
    sections: z
      .array(z.object({ title: z.string(), items: z.array(z.object({ title: z.string(), body: z.string() })) }))
      .default([]),
    outreach: z.array(z.object({ title: z.string(), body: z.string() })).default([]),
  }),
});

export const collections = { teams };
