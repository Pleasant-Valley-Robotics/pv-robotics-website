// Site-wide content. Edit these lists to update the About, Sponsors and footer areas.

export const site = {
  name: 'Pleasant Valley FIRST Robotics',
  shortName: 'PV Robotics',
  tagline: 'Solving problems. Impacting lives.',
  school: 'Pleasant Valley High School',
  location: 'Bettendorf, Iowa',
  // TODO: a general inbox for sponsors and prospective mentors. The old site used a
  // Squarespace form; until there is a shared address, inquiries go to No Limit's inbox.
  contactEmail: 'FRC9082@gmail.com',
};

// Each team's own site, served by the robotics server from the team's repository.
export const teamUrl = (number: number) => `https://${number}.firstpvrobotics.com`;

export const nav = [
  { label: 'About', href: '/about' },
  { label: 'Radical', href: teamUrl(7196) },
  { label: 'Deviation', href: teamUrl(6093) },
  { label: 'Prime Suspects', href: teamUrl(38350) },
  { label: 'No Limit', href: teamUrl(9082) },
  { label: 'Sponsors', href: '/sponsors' },
  { label: 'Contact', href: '/contact' },
];

export const mentors = [
  { name: 'Jason Franzenburg', role: 'Coach' },
  { name: 'Brandon Seamer', role: 'Coach' },
  { name: 'Greg Smith', role: 'Coach' },
  { name: 'Mason Hancock', role: 'Engineering Mentor' },
  { name: 'Mike Brand', role: 'Engineering Mentor' },
  { name: 'Andrew Meckley', role: 'Business Mentor' },
  { name: 'Richard Naylor', role: 'Machinery Mentor' },
  { name: 'Kane Greenwalt', role: 'Media Mentor' },
  { name: 'Angie Brand', role: 'Media Mentor' },
  { name: 'Ricky Naylor', role: 'Mentor' },
];

export const sponsors = [
  { name: 'John Deere', logo: '/images/sponsors/john-deere.png' },
  { name: 'NASA', logo: '/images/sponsors/nasa.png' },
  { name: 'Gene Haas Foundation', logo: '/images/sponsors/gene-haas-foundation.webp' },
  { name: 'MidAmerican Energy', logo: '/images/sponsors/midamerican-energy.png' },
  { name: 'REV Robotics', logo: '/images/sponsors/rev-robotics.webp' },
  { name: 'Argosy Foundation', logo: '/images/sponsors/argosy-foundation.png' },
  { name: 'Scott County Regional Authority', logo: '/images/sponsors/scott-county-regional-authority.jpg' },
  { name: 'Scott County Community Foundation', logo: '/images/sponsors/scott-county-community-foundation.png' },
  { name: 'Pleasant Valley Community School District', logo: '/images/sponsors/pleasant-valley-csd.png' },
];

export const programs = [
  {
    name: 'FIRST Tech Challenge',
    code: 'FTC',
    body: 'Design, program and drive a robot in an alliance-style competition. Teams of up to fifteen PVCSD students in grades 9–12.',
  },
  {
    name: 'FIRST Robotics Competition',
    code: 'FRC',
    body: 'Everything FTC teaches, at industrial scale, plus fundraising, branding and large-team collaboration. Open to any number of PVCSD students in grades 9–12.',
  },
];

export const pathways = [
  {
    name: 'Engineering',
    courses: [
      'Introduction to Engineering',
      'Robotics Engineering',
      'Principles of Engineering',
      'Civil Engineering and Architecture',
      'Engineering Problems',
      'Engineering Academy',
      'CAD 140 – Parametric Solid Modeling',
    ],
  },
  {
    name: 'CNC Machining',
    courses: [
      'Introduction to Manufacturing and Mechanics',
      'Advanced Manufacturing',
      'MFG 106 – Workplace Safety',
      'MFG 371 – Manual Projects',
      'MFG 192 – Blueprint Reading',
      'MFG 201 – CNC Training',
      'MFG 221 – CNC Milling Operator',
      'MFG 139 – Intro to CAD/CAM',
    ],
  },
  {
    name: 'Welding',
    courses: [
      'MFG 361 – VR Welding',
      'WEL 362 – Fundamentals of Welding',
      'WEL 363 – Welding Defects',
      'WEL 364 – GMAW',
      'WEL 365 – Flux Core and Metal Cutting',
      'WEL 366 – SMAW',
      'WEL 191 – GTAW',
      'WEL 367 – Advanced Welding Blueprint Reading',
    ],
  },
];
